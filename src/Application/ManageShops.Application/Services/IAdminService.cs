using ManageShops.Application.Models.DTOs;
using ManageShops.Application.Models.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.Services
{
    public interface IAdminService
    {
        Task CreateManager(AddManagerDTO addManagerDTO);
        Task<List<ManagersListVM>> GetManagers();
        Task<UpdateMenagerDTO> GetManager(Guid id);
        Task UpdateManager(UpdateMenagerDTO updateManagerDTO);

        Task DeleteManager(Guid id);

    }
}
