namespace LeaveManagementSystem.Web.ViewModels.Periods
{
    public class PeriodsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
