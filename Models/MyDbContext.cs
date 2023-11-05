using CourseManagementSystemFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagementSystemFinal.Models
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        //public MyDbContext(DbContextOptions options) : base(options)
        //{

        //}
        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public virtual DbSet<SignUpModel> SignUpModel { get; set; }
     //   public virtual DbSet<FindCourse> FindCourse { get; set; }
        public virtual DbSet<EnrollCourse> EnrollCourse { get; set; }
    }
}