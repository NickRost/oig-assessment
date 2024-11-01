using OIG.Survey.DLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OIG.Survey.BLL.Services
{
    public interface IUserService
    {
        Task<List<ApplicationUser>> GetUsers();
        Task<ApplicationUser> GetUserById(string id);
    }
}
