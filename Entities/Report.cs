using System.Reflection.Metadata;
namespace ReportsManager.Entities
{
    public class Report
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, ReportParameter> Parameters { get; set; }
        public string SampleOutput { get; set; }
    }
}
