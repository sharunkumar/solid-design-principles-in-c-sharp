using OCP.OpenClosedPrinciple.CommonTypes;

namespace OCP.OpenClosedPrinciple.Bad
{
    public class ReportGenerationHelper
    {
        public string GenerateReport(ReportInfo report)
        {
            string generatedPath = string.Empty;

            if (report.ReportType == "EXCEL")
            {
                // Logic to generate Excel file
                // ....  
                generatedPath = @"%appdata%\Info\Report.xls";
            }
            else if (report.ReportType == "PDF")
            {
                // Logic to generate PDF file
                // ....  
                generatedPath = @"%appdata%\Info\Report.pdf";
            }
            else if (report.ReportType == "WORD")
            {
                // Logic to generate WORD file
                // ....  
                generatedPath = @"%appdata%\Info\Report.docx";
            }

            // And if I want to add the generation in XML ???

            else if (report.ReportType == "XML")
            {
                // ...
                generatedPath = @"%appdata%\Info\Report.mxl";
            }

            return generatedPath;
        }
    }
}
