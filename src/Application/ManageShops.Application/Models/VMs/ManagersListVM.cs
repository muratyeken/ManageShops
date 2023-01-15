﻿using ManageShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageShops.Application.Models.VMs
{
    public class ManagersListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Roles Roles { get; set; }
        public string ImagePath { get; set; }
    }
}
