using System.Text.Json;
using BackEndDeveloperTask.Models;
using BackEndDeveloperTask.Services.Interfaces;
using Microsoft.Extensions.Options;

namespace BackEndDeveloperTask.Services
{
    public class JobService : IJobService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<AppSettings> _settings;

        public JobService(HttpClient httpClient, IOptions<AppSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings;
        }

        public async Task<List<JobViewModel>> GetAllJobs(int? max = null)
        {
            List<JobViewModel> result = [];
            var response = await _httpClient.GetAsync(_settings.Value.JobApiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var jobs = JsonSerializer.Deserialize<JobResult>(json)?.Jobs?.OrderByDescending(x => x.Date)?.ToList() ?? [];

                if (max.HasValue)
                {
                    result = jobs.Take(max.Value).Select(Map).ToList();
                }
                else
                {
                    result = jobs.ConvertAll(Map);
                }
            }

            return result;
        }

        private static JobViewModel Map(Job job)
        {
            var openToRemote = bool.Parse(GetMetaDataItem(job.MetaData, Constants.MetaDataNames.OpenToRemote) ?? "False");

            return new()
            {
                Id = job.Id,
                Title = job.Title,
                Date = job.Date,
                Location = job.Location?.Name,
                Department = string.Join(",", job.Departments?.Select(x => x.Name) ?? []),
                OpenToRemote = openToRemote ? "Yes" : "No",
                PayRateType = GetMetaDataItem(job.MetaData, Constants.MetaDataNames.PayRateType) ?? string.Empty,
                Description = job.Content
            };
        }

        private static string? GetMetaDataItem(MetaData[] metaData, string name)
        {
            return Array.Find(metaData, x => x.Name.Equals(name))?.Value?.ToString();
        }
    }
}
