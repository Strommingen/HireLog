using HireLog.Data;
using HireLog.Data.Entities;
using Microsoft.VisualBasic;

namespace HireLog.Services
{
    public class ApplicationRepository
    {
        private readonly AppDbContext _db;

        public ApplicationRepository(AppDbContext db)
        {
            _db = db;
        }

        // testing data
        // private readonly List<Application> _applications = new List<Application>()
        // {
        //     new Application() { Id = new Guid(), ApplicationDate = DateTime.Today, Position = "Software Developer", Company = "Corp AB", State = JobState.Applied},
        //     new Application() { Id = new Guid(), ApplicationDate = DateTime.Today.AddDays(-1), Position = "QA", Company = "Soft AB", State = JobState.Applied}

        // };

        public IEnumerable<Application> GetAll() => _db.Applications.ToList();

        public void Add(Application application)
        {
            application.Id = Guid.NewGuid();
            if (application.ApplicationDate == DateTime.MinValue)
            { // default value, user has not specified
                application.ApplicationDate = DateTime.Today;
            }

            _db.Applications.Add(application);
            _db.SaveChanges();
        }
    }
}