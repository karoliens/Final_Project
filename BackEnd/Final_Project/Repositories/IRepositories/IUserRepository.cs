using Final_Project.Dto;
using Final_Project.Models;

namespace Final_Project.Repositories.IRepositories
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        User Register(RegistrationRequest registrationRequest);
    }
}
