using System.ComponentModel.DataAnnotations;

namespace LeaveManagerMVC.Model
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }
        public string? Type { get; set; }
        public int LeaveDays { get; set; }
    }
}
