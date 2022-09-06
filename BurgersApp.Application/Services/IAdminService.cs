using BurgersApp.Application.Dto.Admin;
using BurgersApp.Application.Dto.Home;

namespace BurgersApp.Application.Services
{
    public interface IAdminService
    {
        AdminDto GetAdmin(int id);
        AdminDto Login(LoginDto loginDto);
    }
}