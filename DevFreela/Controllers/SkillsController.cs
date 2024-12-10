using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/skills")]
public class SkillsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult Post(CreateSkillInputModel model)
    {
        return Ok();
    }
}