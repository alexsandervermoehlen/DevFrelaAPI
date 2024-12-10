using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult post(CreateUserInputModel model)
    {
        return Ok();
        
    }

    [HttpPost("{id}/skills")]
    public IActionResult PostSkills(UserSkillsInputModel model)
    {
        return NoContent();
    }

    [HttpPut("{id}/profile-picture")]
    public IActionResult PostProfilePicture(IFormFile file)
    {
        var description = $"File: {file.FileName}, Size: {file.Length}";
        
        //Processa imagem

        return Ok(description);
    }
    
}
    