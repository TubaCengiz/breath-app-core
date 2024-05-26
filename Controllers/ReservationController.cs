using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace breath_app_core.Controllers {
    using breath_app_core.Model.DbContext;
    using breath_app_core.Services;
    using BreathApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase {
        private readonly ReservationService _reservationService;
        public ReservationController(IGenericEntityService<ReservationInfo> reservationService) {
            _reservationService = (ReservationService)reservationService;
        }

        [HttpPost("CreateReservation")]
        public void CreateReservation(ReservationInfo reservation) {
            _reservationService.Add(reservation);
        }

        [HttpGet("GetAllReservationByCustomerId")]
        public List<ReservationInfo> GetAllReservationByCustomerId(long id) {
            return _reservationService.GetAllReservationByCustomerId(id);
        }

        [HttpGet("GetAllReservationByTherapystId")]
        public List<ReservationInfo> GetAllReservationByTherapystId(long id) {
            return _reservationService.GetAllReservationByTherapystId(id);
        }
    }
}