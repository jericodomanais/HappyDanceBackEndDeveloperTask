namespace BackEndDeveloperTask.Models
{
    public class JobViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string? Location { get; set; }
        public string Department { get; set; } = string.Empty;
        public string OpenToRemote { get; set; } = string.Empty;
        public string PayRateType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
