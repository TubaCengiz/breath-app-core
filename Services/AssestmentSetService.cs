using breath_app_core.Model.DbContext;
using BreathApp.Models;

namespace breath_app_core.Services {
    public class AssestmentSetService(BreathContext context) : GenericEntityService<AssessmentSet>(context) {
    }
}
