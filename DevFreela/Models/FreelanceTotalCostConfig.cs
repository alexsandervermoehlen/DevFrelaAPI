using System.ComponentModel.DataAnnotations.Schema;

namespace DevFreela.Models;

public class FreelanceTotalCostConfig
{
    [Column(TypeName = "decimal(18,2)")]
    public decimal Minimum { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Maximum { get; set; }
}