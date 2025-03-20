using HotelSystem.Models;
using HotelSystem.Models.Enum;
using HotelSystem.Repository;

namespace HotelSystem.Services
{
    public class UserService
    {
        GeneralRepository<Staff> _repo;
        public UserService(GeneralRepository<Staff> repo)
        {
            _repo = repo;
        }

        public void Login(string userName , string passWord)

        {
            _repo.Add(new RoleFeature { Role = role, Feature = feature });
            _repo.SaveChanges();
        }
    }
}
