using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.ViewModels.LeaveTypes
{
    public abstract class BaseLeaveTypeVM
    {
        public int LeaveTypeId { get; set; }

        //[Required]
        //[Length(4, 150, ErrorMessage = "Minimum length is 5 and max length is 150")]
        //public string? Name { get; set; }

        //[Required]
        //[Range(1, 90)]
        //[Display(Name = "Number of Days")]
        //public int NumberOfDays { get; set; }
    }
}
