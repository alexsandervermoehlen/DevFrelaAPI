using System.ComponentModel.DataAnnotations.Schema;

namespace DevFreela.Models;

public class UpdateProjectInputModel
{
    public int IdProject { get; set; }
    
    public string Title { get; set; }
    
    public string  Description { get; set; }
    
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalCost { get; set; }
}