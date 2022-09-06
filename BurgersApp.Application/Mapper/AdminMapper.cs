using BurgersApp.Application.Dto.Admin;
using BurgersApp.Domain.Models;

namespace BurgersApp.Application.Mapper
{
    public static class AdminMapper
    {
        public static AdminDto ToAdminDto(this Admin admin)
        {
            return new AdminDto()
            {
                Id = admin.Id,
                FirstName = admin.FirstName,    
                LastName = admin.LastName,
                Username = admin.Username,
                Password = admin.Password,
            };
        }
    }
}