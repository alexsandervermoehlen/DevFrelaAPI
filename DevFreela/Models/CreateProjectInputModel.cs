using System.ComponentModel.DataAnnotations.Schema;
using DevFreela.Entities;

namespace DevFreela.Models;

public class CreateProjectInputModel
{
    public string Title { get; set; }
    
    public string  Description { get; set; }
    
    public int IdClient { get; set; }
    
    public int IdFreelancer { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalCost { get; set; }
    
    public Project ToEntity()
        => new(Title, Description, IdClient, IdFreelancer, TotalCost);
}