using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace breath_app_core.Controllers
{
    using breath_app_core.Model.DbContext;
    using breath_app_core.Services;
    using BreathApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileService _profileService;
        private readonly ContactService _contactService;
        public ProfileController(IGenericEntityService<Profile> profileService, IGenericEntityService<Contact> contactService)
        {
            _profileService = (ProfileService)profileService;
            _contactService = (ContactService)contactService;
        }

        [HttpPost("UpdateContactInformations")]
        public ActionResult<bool> UpdateContactInformations(Contact contact)
        {
            _contactService.Update(contact);
            return true;
        }

        [HttpGet("GetAllTherapysts")]
        public ActionResult<List<Profile>> GetAllTherapysts() {
            return _profileService.GetAllProfilesByType(ProfileType.Therapyst);
        }
    }
}