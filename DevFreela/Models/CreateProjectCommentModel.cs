namespace DevFreela.Models;

public class CreateProjectCommentModel
{
    public string Comment { get; set; }
    
    public int IdProject { get; set; }

    public int IdUser { get; set; }
}