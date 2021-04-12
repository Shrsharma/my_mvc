using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Models
{
    public class TeacherModel : BaseModel
    {
         
        public string TeacherName { get; set; }

    }
}
