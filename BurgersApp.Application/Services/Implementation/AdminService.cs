using BurgersApp.Application.Dto.Admin;
using BurgersApp.Application.Dto.Home;
using BurgersApp.Application.Mapper;
using BurgersApp.Application.Repository;
using BurgersApp.Domain.Models;
using Isopoh.Cryptography.Argon2;

namespace BurgersApp.Application.Services.Implementation
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Admin> repository;
        public AdminService(IRepository<Admin> repository)
        {
            this.repository = repository;
        }
        public AdminDto GetAdmin(int id)
        {
            var admin = repository.GetById(id);

            if (admin == null)
            {
                throw new Exception("Not found");
            }
            return admin.ToAdminDto();
        }
        public AdminDto Login(LoginDto loginDto)
        {
            var admin = repository.GetAll()
                                  .FirstOrDefault(x => x.Username == loginDto.Userame); //TO DO, change repository and entire logic when users will be added
            //use -> Username: Johnsy11990055, Password: desetbukvi to Log In
            if (admin == null)
            {
                throw new Exception("Unauthorized");
            }
            //can't seed with hash
            if (admin.Password != loginDto.Password)
            {
                throw new Exception("Unauthorized");
            }

            return admin.ToAdminDto();
        }
    }
}