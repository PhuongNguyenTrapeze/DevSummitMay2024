using ReportsManager.Entities;

namespace ReportsManager.Services
{
    public class ReportService
    {
        private List<Report> _reports;

        public ReportService()
        {
            _reports = new List<Report>();
            // TODO: Initialize _reports with actual data
        }

        public List<Report> SearchReports(string fileName, string description, string content)
        {
            return _reports.Where(r => r.Name.Contains(fileName)
                && r.Description.Contains(description)
                && r.Content.Contains(content)).ToList();
        }
    }
}
