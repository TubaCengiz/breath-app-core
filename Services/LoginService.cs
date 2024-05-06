using breath_app_core.Model.DbContext;
using BreathApp.Models;
using Microsoft.EntityFrameworkCore;

namespace breath_app_core.Services {
    public class LoginService(BreathContext context) : GenericEntityService<Profile>(context) {
        public Profile GetProfileByLoginName(string loginName) {

            return _dbSet.FirstOrDefault<Profile>(x => x.LoginInformation.LoginName == loginName);
        }
    }   
}
