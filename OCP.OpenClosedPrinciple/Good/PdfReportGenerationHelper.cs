using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Good
{
    public class PdfReportGenerationHelper : ReportGenerationHelper
    {
        public override string GenerateReport(ReportInfo report)
        {
            string generatedPath = null;

            // Logic to generate PDF file
            // ....  
            // ....  
            generatedPath = @"%appdata%\Info\Report.pdf";

            return generatedPath;
        }
    }
}
