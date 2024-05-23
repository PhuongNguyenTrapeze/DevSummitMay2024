using ReportsManager.Entities;

namespace ReportsManager.Services
{
    // ReportService.cs
    public class ReportService
    {
        public List<Report> GetReports()
        {
            // Fetch the reports from your data source here
            // For simplicity, I'm just returning a static list of reports
            return new List<Report>
            {
                new Report { Id = "1", Name = "Report 1" },
                new Report { Id = "2", Name = "Report 2" },
                // Add more reports as needed
            };
        }
    }
}
