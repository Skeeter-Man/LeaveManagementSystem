using LeaveManagementSystem.Web.ViewModels.LeaveTypes;
using LeaveManagementSystem.Web.ViewModels.Periods;

namespace LeaveManagementSystem.Web.ViewModels.LeaveAllocations
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }

        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        public PeriodsVM Period { get; set; } = new ();

        public LeaveTypeReadOnlyVM? LeaveType { get; set; }
    }
}
