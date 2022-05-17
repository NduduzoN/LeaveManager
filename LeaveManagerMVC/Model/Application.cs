using System.ComponentModel.DataAnnotations;

namespace LeaveManagerMVC.Model
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
