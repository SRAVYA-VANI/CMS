using CourseManagementSystemFinal.Models;

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManagementSystemFinal.Repositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(Login login);
        IEnumerable<ApplicationUser> GetAllUsers();
        Task<ApplicationUser> GetUserByIdAsync(string id);

        Task<bool> DeleteCourseByNameAsync(string courseName);


    }
}

