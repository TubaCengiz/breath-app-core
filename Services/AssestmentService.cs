using breath_app_core.Model.DbContext;
using BreathApp.Models;

namespace breath_app_core.Services {
    public class AssestmentService(BreathContext context) : GenericEntityService<Assessment>(context) {
        public List<Assessment> GetAssesmentsBySetId(long id) {
            return _dbSet.Where(x => x.TestSetId == id).ToList();
        }
    }
}
