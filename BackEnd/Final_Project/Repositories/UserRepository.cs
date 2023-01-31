using Final_Project.Data;
using Final_Project.Dto;
using Final_Project.Models;
using Final_Project.Repositories.IRepositories;

namespace Final_Project.Repositories
{
    /*
    public class UserRepository : IUserRepository
    {
        private readonly RepairShopContext _db;
        private string _sekretKey;

        public UserRepository(RepairShopContext db, IConfiguration conf)
        {
            _db = db;
            _sekretKey = conf.GetValue<string>("ApiSettings:Secret");
        }
        public bool IsUniqueUser(string username)
        {
            var user = _db.Users.FirstOrDefault(x => x.Username == username);
            
            if(user == null)
            {
                return true;
            }

            return false;
        }

        public LoginResponse Login(LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }

        /*public User Register(RegistrationRequest registrationRequest)
        {
            User user = new()
            {
                Username = registrationRequest.Username,
                Password = registrationRequest.Password,
                Name = registrationRequest.Name,
            };
        }
        
    }*/
}
