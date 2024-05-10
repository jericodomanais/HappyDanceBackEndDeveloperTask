using System.Text.Json.Serialization;

namespace BackEndDeveloperTask.Models
{
    public class JobResult
    {
        [JsonPropertyName("jobs")]
        public List<Job> Jobs { get; set; } = [];
    }
}