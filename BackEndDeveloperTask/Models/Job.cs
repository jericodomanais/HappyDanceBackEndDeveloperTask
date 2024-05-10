using System.Text.Json.Serialization;

namespace BackEndDeveloperTask.Models
{
    public class Job
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("updated_at")]
        public DateTime Date { get; set; }

        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("departments")]
        public Department[] Departments { get; set; } = [];

        [JsonPropertyName("metadata")]
        public MetaData[] MetaData { get; set; } = [];

        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }

    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class Department
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class MetaData
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }
}
