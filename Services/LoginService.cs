using breath_app_core.Model.DbContext;
using BreathApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace breath_app_core.Services {
    public class LoginService(BreathContext context) : GenericEntityService<LoginInformation>(context) {
        public LoginInformation GetLoginInformationById(long id) {
            LoginInformation loginInformation = _dbSet.FirstOrDefault<LoginInformation>(x => x.Id == id);
            return loginInformation;
        }
    }
}
