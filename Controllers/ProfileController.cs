using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace breath_app_core.Controllers {
    using breath_app_core.Services;
    using BreathApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase {
        private readonly ProfileService _profileService;

        public ProfileController(IGenericEntityService<Profile> profileService) {
            _profileService = (ProfileService)profileService;
        }

        [HttpGet("{id}")]
        public ActionResult<Profile> GetById(int id) {
            var profile = _profileService.GetById(id);
            if (profile == null) {
                return NotFound();
            }
            return profile;
        }

        [HttpGet]
        public ActionResult<List<Profile>> GetAll() {
            return _profileService.GetAll();
        }

        [HttpPost]
        public IActionResult Create(Profile profile) {
            _profileService.Add(profile);
            return CreatedAtAction(nameof(GetById), new { id = profile.Id }, profile);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Profile profile) {
            if (id != profile.Id) {
                return BadRequest();
            }

            _profileService.Update(profile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _profileService.Delete(id);
            return NoContent();
        }
    }
}