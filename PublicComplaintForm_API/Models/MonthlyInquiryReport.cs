namespace PublicComplaintForm_API.Models
{
    public class MonthlyInquiryReport
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        public int CurrentMonthCount { get; set; }

        public int PreviousMonthCount { get; set; }

        public int SameMonthLastYearCount { get; set; }

        public int DifferenceFromPreviousMonth =>
            CurrentMonthCount - PreviousMonthCount;

        public int DifferenceFromLastYear =>
            CurrentMonthCount - SameMonthLastYearCount;
    }
}