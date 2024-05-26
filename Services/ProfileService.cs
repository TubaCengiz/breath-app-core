using breath_app_core.Model.BaseEntities;
using breath_app_core.Model.DbContext;
using BreathApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace breath_app_core.Services {
    public class ProfileService : GenericEntityService<Profile> {
        public ProfileService(BreathContext context) : base(context) {

        }
        public Profile GetProfileByLoginName(string loginName) => _dbSet
                .Include(x => x.ContactInformation)
                .Include(x => x.LoginInformation)
                .FirstOrDefault(x => x.LoginInformation.LoginName == loginName);

        public List<Profile> GetAllProfilesByType(ProfileType profileType) {
            return _dbSet.Include(x => x.ContactInformation)
                                             .Where(x => x.Type == profileType).ToList();
        }

    }
}
