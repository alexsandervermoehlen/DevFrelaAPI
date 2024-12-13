using DevFreela.Models;
using DevFreela.Persistence;
using DevFreela.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    private readonly DevFreelaDbContext _context;
    public ProjectsController(DevFreelaDbContext context)
    {
        _context = context;
    }
    
    //GET api/projects?search=crm
    [HttpGet]
    public IActionResult Get(string search = "")
    {
        var projects = _context.Projects.Where(p => !p.IsDeleted).ToList();

        var model = projects.Select(p => new ProjectItemViewModel.FromEntity(p));
        return Ok();
    }
    
    //GET api/projects/1234
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
    
    // POST api/projects
    [HttpPost]
    public IActionResult Post(CreateProjectInputModel model)
    {
        //if (model.TotalCost < _config.Minimum || model.TotalCost > _config.Maximum)
        //{
           // return BadRequest("Valor fora do limite.");
        //}
        return CreatedAtAction(nameof(GetById), new { id = 1}, model);
    }
    
    //PUT api/projects/1234
    [HttpPut("{id}")]
    public IActionResult Put(int id, UpdateProjectInputModel model)
    {
        return NoContent();
    }
    
    // DELETE  api/projects/1234
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
    
    //PUT api/projrcts/1234/start
    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        return NoContent();
    }
    
    //PUT api/projrcts/1234/complete
    [HttpPut("{id}/complete")]
    public IActionResult Complete(int id)
    {
        return NoContent();
    }
    
    // POST api/projects/1234/coments
    [HttpPost("{id}/coments")]
    public IActionResult PostComents(int id, CreateProjectCommentModel model)
    {
        return Ok();
    }
}