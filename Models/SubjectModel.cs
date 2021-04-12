using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Models
{
    public class SubjectModel : BaseModel
    {
        
        public string SubjectName { get; set; }
    }
}
