using BackEndDeveloperTask.Models;

namespace BackEndDeveloperTask.Services.Interfaces
{
    public interface IJobService
    {
        Task<List<JobViewModel>> GetAllJobs(int? max = null);
    }
}
