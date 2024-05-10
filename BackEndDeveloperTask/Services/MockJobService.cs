using BackEndDeveloperTask.Models;
using BackEndDeveloperTask.Services.Interfaces;

namespace BackEndDeveloperTask.Services
{
    public class MockJobService : IJobService
    {
        public Task<List<JobViewModel>> GetAllJobs(int? max = null)
        {
            List<JobViewModel> jobs = PopulateJobs().OrderByDescending(x => x.Date).ToList();

            if (max.HasValue)
            {
                return Task.FromResult(jobs.Take(max.Value).ToList());
            }

            return Task.FromResult(jobs);
        }

        private List<JobViewModel> PopulateJobs()
        {
            return
            [
                new JobViewModel { Id = 1, Title = "Software Consultant", Date = DateTime.Parse("5/10/2024"), Location = "Mora", Department = "Accounting", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Quality Control Specialist", Date = DateTime.Parse("5/8/2024"), Location = "Wujiashan", Department = "Services", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Nurse", Date = DateTime.Parse("5/1/2024"), Location = "Mora", Department = "Accounting", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Budget/Accounting Analyst IV", Date = DateTime.Parse("5/1/2024"), Location = "Wiang Nuea", Department = "Services", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Chief Design Engineer", Date = DateTime.Parse("5/4/2024"), Location = "Petaling Jaya", Department = "Engineering", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Assistant Professor", Date = DateTime.Parse("5/3/2024"), Location = "Loreto", Department = "Engineering", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Systems Administrator I", Date = DateTime.Parse("5/8/2024"), Location = "Mora", Department = "Human Resources", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Junior Executive", Date = DateTime.Parse("5/7/2024"), Location = "Kultayevo", Department = "Support", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Media Manager II", Date = DateTime.Parse("4/8/2024"), Location = "Zarzal", Department = "Sales", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Design Engineer", Date = DateTime.Parse("18/4/2024"), Location = "Oematnunu", Department = "Research and Development", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Programmer II", Date = DateTime.Parse("4/3/2024"), Location = "Isheyevka", Department = "Accounting", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Business Systems Development Analyst", Date = DateTime.Parse("3/8/2024"), Location = "El Cardo", Department = "Support", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Recruiting Manager", Date = DateTime.Parse("3/8/2024"), Location = "Dongsheng", Department = "Marketing", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Occupational Therapist", Date = DateTime.Parse("4/7/2024"), Location = "Lobos", Department = "Training", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
                new JobViewModel { Id = 1, Title = "Environmental Tech", Date = DateTime.Parse("5/3/2024"), Location = "Shanyang", Department = "Training", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris accumsan lorem in blandit semper. Donec eget justo nec erat luctus varius. Vestibulum viverra pretium urna, ac viverra nunc sodales tincidunt.", OpenToRemote = "Yes", PayRateType = "Salary" },
            ];
        }
    }
}
