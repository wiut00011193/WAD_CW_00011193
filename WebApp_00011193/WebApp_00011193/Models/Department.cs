using System.ComponentModel.DataAnnotations;

namespace WebApp_00011193.Models
{
    public class Department
    {
        public int ID { get; set; }

        [Display(Name = "Department")]
        public string Name { get; set; }
    }
}
