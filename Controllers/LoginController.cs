using breath_app_core.Model.DbContext;
using breath_app_core.Services;
using BreathApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BreathApp.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController(IGenericEntityService<Profile> profileService, IGenericEntityService<LoginInformation> loginService, IGenericEntityService<Contact> contactService) : ControllerBase
{
    private readonly LoginService _loginService = (LoginService)loginService;
    private readonly ProfileService _profileService = (ProfileService)profileService;
    private readonly ContactService _contactService = (ContactService)contactService;

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<bool> CreateProfile(Profile userProfile)
    {
        _profileService.Add(userProfile);
        return true;
    }

    [HttpGet("ValidateUser")]
    public ActionResult<Profile> GetLoginInformation(string userName, string password)
    {
        Profile information = _profileService.GetProfileByLoginName(userName);      
        if (information == null)
        {
            throw new Exception("profil bilgileri bulunamadı");
        }

        if (password == information.LoginInformation.Password)
        {
            return information;
        }

        throw new Exception("şifre yanlış");
    }
}