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
    public class AssessmentController : ControllerBase {
        private readonly AssestmentService _assesmentService;
        private readonly AssestmentSetService _assestmentSetService;
        public AssessmentController(IGenericEntityService<Assessment> assessmentService, IGenericEntityService<AssessmentSet> assessmentSetService) {
            _assesmentService = (AssestmentService)assessmentService;
            _assestmentSetService = (AssestmentSetService)assessmentSetService;
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

        [HttpGet("GetAllSet")]
        public ActionResult<List<AssessmentSet>> GetAllSet() {
            return _assestmentSetService.GetAll();
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