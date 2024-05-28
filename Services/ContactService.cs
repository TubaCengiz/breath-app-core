using breath_app_core.Model.DbContext;
using BreathApp.Models;

namespace breath_app_core.Services {
    public class ContactService(BreathContext context) : GenericEntityService<Contact>(context) {
     
    }
}
