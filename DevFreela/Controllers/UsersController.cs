using DevFreela.Entities;
using DevFreela.Models;
using DevFreela.Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly DevFreelaDbContext _context;

    public UsersController(DevFreelaDbContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _context.Users
            .Include(u => u.Skills)
            .ThenInclude(u => u.Skill)
            .SingleOrDefault(u => u.Id == id);

        if (user is null)
        {
            return NotFound();
        }

        var model = UserViewModel.FromEntity(user);
        
        return Ok(model);
    }
    
    [HttpPost]
    public IActionResult post(CreateUserInputModel model)
    {
        var user = new User(model.FullName, model.Email, model.BirthDate);
        
        _context.Users.Add(user);
        _context.SaveChanges();
        
        return NoContent();
    }

    [HttpPost("{id}/skills")]
    public IActionResult PostSkills(int id, UserSkillsInputModel model)
    {
        var userSkils = model.SkillIds.Select(s => new UserSkill(id, s)).ToList();
        
        _context.UserSkills.AddRange(userSkils);
        _context.SaveChanges();
        
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
    