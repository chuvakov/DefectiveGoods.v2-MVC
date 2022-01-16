﻿using System;
using System.ComponentModel.DataAnnotations;
using DefectiveGoods.Core.Infrastructure.Entities;

namespace DefectiveGoods.Core.Branches
{
    public class Branch : Entity<int>
    {
        [MaxLength(4)]
        [Required]
        public string CodeName { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }        
    }
}
