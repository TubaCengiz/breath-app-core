using breath_app_core.Model.DbContext;
using BreathApp.Models;

namespace breath_app_core.Services {
    public class AssessmentService(BreathContext context) : GenericEntityService<Assessment>(context) {
    }
}
