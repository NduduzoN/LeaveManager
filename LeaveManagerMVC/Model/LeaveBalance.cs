using System.ComponentModel.DataAnnotations;

namespace LeaveManagerMVC.Model
{
    public class LeaveBalance
    {
        [Key]
        public int Id { get; set; }
        public int LeaveType { get; set; }
        public int Balance { get; set; }
    }
}
