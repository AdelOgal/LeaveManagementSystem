using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;
        
        [Display(Name = "Maximum Allocations of Days")]
        public int NumberOfDays { get; set; }
    }

};

