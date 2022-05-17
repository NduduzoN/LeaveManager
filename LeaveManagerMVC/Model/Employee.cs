using System.ComponentModel.DataAnnotations;

namespace LeaveManagerMVC.Model
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
