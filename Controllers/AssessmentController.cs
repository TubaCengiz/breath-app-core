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
        private readonly AssessmentResultService _assessmentResultService;
        public AssessmentController(IGenericEntityService<Assessment> assessmentService, IGenericEntityService<AssessmentSet> assessmentSetService, IGenericEntityService<AssessmentResult> assessmentResultService) {
            _assesmentService = (AssestmentService)assessmentService;
            _assestmentSetService = (AssestmentSetService)assessmentSetService;
            _assessmentResultService = (AssessmentResultService)assessmentResultService;
        }

        [HttpGet("{id}")]
        public ActionResult<Assessment> GetById(int id) {
            var assessment = _assesmentService.GetById(id);
            if (assessment == null) {
                return NotFound();
            }
            return assessment;
        }

        [HttpGet("GetAllBySetId")]
        public ActionResult<List<Assessment>> GetAllBySetId(int id) {
            var assessment = _assesmentService.GetAssesmentsBySetId(id);
            if (assessment == null) {
                return NotFound();
            }
            return assessment;
        }

        [HttpGet("GetAllSet")]
        public ActionResult<List<AssessmentSet>> GetAllSet() {
            return _assestmentSetService.GetAll();
        }

        [HttpPost("SaveTestResult")]
        public void SaveTestResult(AssessmentResult res) {
            _assessmentResultService.Add(res);
        }
    }
}