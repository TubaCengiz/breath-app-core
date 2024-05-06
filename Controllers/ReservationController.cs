using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace breath_app_core.Controllers {
    using breath_app_core.Model.DbContext;
    using breath_app_core.Services;
    using BreathApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService) {
            _reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public ActionResult<ReservationInfo> GetById(int id) {
            var reservation = _reservationService.GetById(id);
            if (reservation == null) {
                return NotFound();
            }
            return reservation;
        }

        [HttpGet]
        public ActionResult<List<ReservationInfo>> GetAll() {
            return _reservationService.GetAll();
        }

        [HttpPost]
        public IActionResult Create(ReservationInfo reservation) {
            _reservationService.Add(reservation);
            return CreatedAtAction(nameof(GetById), new { id = reservation.Id }, reservation);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ReservationInfo reservation) {
            if (id != reservation.Id) {
                return BadRequest();
            }

            _reservationService.Update(reservation);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _reservationService.Delete(id);
            return NoContent();
        }
    }
}