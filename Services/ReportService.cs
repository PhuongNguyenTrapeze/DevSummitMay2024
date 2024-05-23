using ReportsManager.Entities;

namespace ReportsManager.Services
{
    public class ReportService
    {
        private readonly List<Report> _reports = new List<Report>
        {
            new Report { Id = "1", Name = "Service Headway" },
            new Report { Id = "2", Name = "Stop Spacing" },
            // Add more reports as needed
        };

        public List<Report> GetReports()
        {
            return _reports;
        }

        public Report GetReport(string id)
        {
            return _reports.First(r => r.Id == id);
        }
    }
}
