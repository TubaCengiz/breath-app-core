using breath_app_core.Model.BaseEntities;
using BreathApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace breath_app_core.Services {
    public class ProfileService : GenericEntityService<Profile> {
        public ProfileService(BreathContext context) : base(context) {
            
        }

        
    }
}
