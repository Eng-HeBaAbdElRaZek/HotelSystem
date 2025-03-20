using HotelSystem.Models;
using HotelSystem.Models.Enum;
using HotelSystem.Repository;

namespace HotelSystem.Services
{
    public class RoleFeatureService
    {
        GeneralRepository<RoleFeature> _repo;
        public RoleFeatureService(GeneralRepository<RoleFeature> repo)
        {
            _repo = repo;
        }

        public void Assign (Role role , Feature feature)

        {
            _repo.Add(new RoleFeature { Role = role, Feature = feature });
            _repo.SaveChanges();
        }
    }
}
