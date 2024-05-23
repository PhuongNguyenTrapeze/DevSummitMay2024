using ReportsManager.Entities;
using System.Text.Json;

namespace ReportsManager.Services
{
    public class ReportService
    {
        private readonly List<Report> _reports;

        public ReportService()
        {
            _reports = new List<Report>();

            // Get all the report files in the reports folder
            var reportFiles = Directory.GetFiles("Reports", "*.json");

            foreach (var reportFile in reportFiles)
            {
                // Read the file content
                var reportContent = File.ReadAllText(reportFile);

                // Deserialize the content into a Report object
                var report = JsonSerializer.Deserialize<Report>(reportContent);

                _reports.Add(report);
            }
        }

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
