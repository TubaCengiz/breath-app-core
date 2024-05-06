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
    public class AssessmentController : ControllerBase {
        private readonly AssessmentService _assesmentService;

        public AssessmentController(AssessmentService assessmentService) {
            _assesmentService = assessmentService;
        }

        [HttpGet("{id}")]
        public ActionResult<Assessment> GetById(int id) {
            var assessment = _assesmentService.GetById(id);
            if (assessment == null) {
                return NotFound();
            }
            return assessment;
        }

        [HttpGet]
        public ActionResult<List<Assessment>> GetAll() {
            return _assesmentService.GetAll();
        }

        [HttpPost]
        public IActionResult Create(Assessment assessment) {
            _assesmentService.Add(assessment);
            return CreatedAtAction(nameof(GetById), new { id = assessment.Id }, assessment);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Assessment assessment) {
            if (id != assessment.Id) {
                return BadRequest();
            }

            _assesmentService.Update(assessment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _assesmentService.Delete(id);
            return NoContent();
        }
    }
}