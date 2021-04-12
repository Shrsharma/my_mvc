using Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options ): base(options)
        {

        }
        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<TeacherModel> TeacherModel { get; set; }
        public DbSet<SubjectModel> SubjectModel { get; set; }

    }
}
