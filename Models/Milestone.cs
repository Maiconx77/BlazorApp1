namespace BlazorApp1.Models
{
    public class Milestone
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
