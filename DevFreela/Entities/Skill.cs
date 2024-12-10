namespace DevFreela.Entities;

public class Skill : BaseEntity
{
    protected Skill(string description) : base()
    {
        Description = description;
    }

    public string Description { get; private set; }
}