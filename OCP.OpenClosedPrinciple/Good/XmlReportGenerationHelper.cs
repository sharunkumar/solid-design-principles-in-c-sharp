using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Good
{
    public class XmlReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(ReportInfo report)
        {
            string generatedPath = null;

            // Logic to generate XML Report
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.xml";

            return generatedPath;
        }
    }
}
