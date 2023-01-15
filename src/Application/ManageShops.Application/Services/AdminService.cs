using AutoMapper;
using ManageShops.Application.Models.DTOs;
using ManageShops.Application.Models.VMs;
using ManageShops.Domain.Entities;
using ManageShops.Domain.Enums;
using ManageShops.Domain.ReposOfDomain;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.Services
{
    public class AdminService :IAdminService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepo _employeeRepo;
        public AdminService(IMapper mapper,IEmployeeRepo employeeRepo)
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;

        }

        public async Task CreateManager(AddManagerDTO addManagerDTO)
        {
            var addEmployee = _mapper.Map<Employee>(addManagerDTO);


            if (addEmployee.UploadPath != null)
            {
                var stream = addManagerDTO.UploadPath.OpenReadStream();
                using var image = Image.Load(stream);
                

                image.Mutate(x => x.Resize(600, 560));

                Guid guid = Guid.NewGuid();
                image.Save($"wwwroot/images/{guid}.jpg");

                addEmployee.ImagePath = ($"/images/{guid}.jpg");
                await _employeeRepo.Create(addEmployee);

            }
            else
            {
                addEmployee.ImagePath = ($"/images/default.jpeg");
                await _employeeRepo.Create(addEmployee);
            }

        }

        public async Task<List<ManagersListVM>> GetManagers()
        {
            var managers = await _employeeRepo.GetFilteredList(
                select: x => new ManagersListVM
                {
                    ID = x.ID,
                    Name = x.Name,
                    Surname = x.Surname,
                    Roles = x.Roles,
                    ImagePath = x.ImagePath,
                },
                where: x => ((x.Status == Status.Active || x.Status == Status.Modified) && x.Roles == Roles.Manager),
                orderBy: x => x.OrderBy(x => x.Name));

            return managers;
        }
    }
}
