using breath_app_core.Migrations;
using breath_app_core.Model.DbContext;
using BreathApp.Models;

namespace breath_app_core.Services {
    public class ReservationService(BreathContext context) : GenericEntityService<ReservationInfo>(context) {
    }
}
