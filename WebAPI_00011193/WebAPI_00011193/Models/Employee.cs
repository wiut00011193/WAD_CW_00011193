namespace WebAPI_00011193.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobPosition { get; set; }
        public decimal Salary { get; set; }
        public Department EmployeeDepartment { get; set; }
    }
}
