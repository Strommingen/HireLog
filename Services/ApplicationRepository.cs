using HireLog.Data.Entities;
using Microsoft.VisualBasic;

namespace HireLog.Services
{
    public class ApplicationRepository
    {
        public List<Application> Applications = new List<Application>()
        {
            new Application() { Id = new Guid(), ApplicationDate = DateTime.Today, Position = "Software Developer", Company = "Corp AB", State = JobState.Applied},
            new Application() { Id = new Guid(), ApplicationDate = DateTime.Today.AddDays(-1), Position = "QA", Company = "Soft AB", State = JobState.Applied}

        };

        public IEnumerable<Application> GetAll() {
            return Applications;
        }
    }
}