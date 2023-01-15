using AutoMapper;
using ManageShops.Application.Models.DTOs;
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
            CreateMap<Employee, AddManagerDTO>().ReverseMap();
        }
    }
}
