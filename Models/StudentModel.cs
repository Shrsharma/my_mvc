﻿using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    
    public class StudentModel : BaseModel
    {
        
        [Required]
        public string Name { get; set; }
    }
}
