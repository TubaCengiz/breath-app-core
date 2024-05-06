using breath_app_core.Model.DbContext;
using breath_app_core.Services;
using BreathApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BreathApp.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase {
    private readonly LoginService _loginService;

    public LoginController(IGenericEntityService<Profile> loginService) {
        _loginService = (LoginService)loginService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<bool> CreateProfile(Profile userProfile) {
        //Db Kayıt...
        //return CreatedAtAction(nameof(GetById), new { id = pet.Id }, pet);
        return true;
    }

    [HttpGet]
    public ActionResult<Profile> GetLoginInformation(string loginName) {
        //Db Kayıt oku...

        return _loginService.GetProfileByLoginName(loginName);

    }


}