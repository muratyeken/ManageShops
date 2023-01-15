using AutoMapper;
using ManageShops.Application.Models.DTOs;
using ManageShops.Application.Models.VMs;
using ManageShops.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Employee,AddManagerDTO>().ReverseMap();
            CreateMap<Employee,ManagersListVM>().ReverseMap();
            CreateMap<UpdateManagerVM,UpdateMenagerDTO>().ReverseMap();
            CreateMap<UpdateMenagerDTO,Employee>().ReverseMap();
            CreateMap<Employee,AddOtherEmployeeDTO>().ReverseMap();
            CreateMap<Employee,EmployeesListVM>().ReverseMap();
            CreateMap<UpdateMenagerDTO,Employee>().ReverseMap();
            CreateMap<UpdateOtherEmployeeDTO,Employee>().ReverseMap();
        }
    }
}
