using breath_app_core.Model.DbContext;
using BreathApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace breath_app_core.Services {
    public class ReservationService(BreathContext context) : GenericEntityService<ReservationInfo>(context) {
        public List<ReservationInfo> GetAllReservationByTherapystId(long id) {
            return _dbSet.Include(x => x.Customer).Include(x=>x.Therapyst).Where(x => x.TherapystId == id).ToList();
        }

        public List<ReservationInfo> GetAllReservationByCustomerId(long id) {
            return _dbSet.Include(x => x.Customer).Include(x => x.Therapyst).Where(x => x.CustomerId == id).ToList();
        }
    }
}
