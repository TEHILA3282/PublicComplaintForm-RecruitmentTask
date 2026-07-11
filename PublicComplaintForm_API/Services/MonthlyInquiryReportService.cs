using PublicComplaintForm_API.Models;

namespace PublicComplaintForm_API.Services
{
    public class MonthlyInquiryReportService
    {
        public List<MonthlyInquiryReport> GetMonthlyReport(DateTime reportMonth)
        {
            return new List<MonthlyInquiryReport>
            {
                new MonthlyInquiryReport
                {
                    DepartmentId = 1,
                    DepartmentName = "מחלקת פניות הציבור",
                    CurrentMonthCount = 125,
                    PreviousMonthCount = 110,
                    SameMonthLastYearCount = 98
                },
                new MonthlyInquiryReport
                {
                    DepartmentId = 2,
                    DepartmentName = "מחלקת מידע",
                    CurrentMonthCount = 84,
                    PreviousMonthCount = 91,
                    SameMonthLastYearCount = 79
                },
                new MonthlyInquiryReport
                {
                    DepartmentId = 3,
                    DepartmentName = "מחלקת שירות",
                    CurrentMonthCount = 142,
                    PreviousMonthCount = 130,
                    SameMonthLastYearCount = 121
                },
                new MonthlyInquiryReport
                {
                    DepartmentId = 4,
                    DepartmentName = "מחלקת גבייה",
                    CurrentMonthCount = 0,
                    PreviousMonthCount = 8,
                    SameMonthLastYearCount = 5
                }
            };
        }
    }
}