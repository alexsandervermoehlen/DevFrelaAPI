using DevFreela.Entities;

namespace DevFreela.Models
{

    public class ProjectItemViewModel
    {
        public ProjectItemViewModel(int id, string title, string description, string clientName, string freelancerName,
            decimal totalCost)
        {
            Id = id;
            Title = title;
            Description = description;
            ClientName = clientName;
            FreelancerName = freelancerName;
            TotalCost = totalCost;
        }

        private ProjectItemViewModel(int projectId, string projectTitle, string clientFullName, string freelancerFullName, decimal projectTotalCost)
        {
            throw new NotImplementedException();
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ClientName { get; private set; }
        public string FreelancerName { get; private set; }
        public decimal TotalCost { get; private set; }


        public static ProjectItemViewModel FromEntity(Project project)
            => new(project.Id, project.Title, project.Client.FullName, project.Freelancer.FullName, project.TotalCost);
    }
}