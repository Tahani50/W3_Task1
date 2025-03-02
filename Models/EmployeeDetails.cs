using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Models
{
    public class EmployeeDetails
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Position { get; set; } = "";

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive value.")]
        public decimal Salary { get; set; }
    }
}
