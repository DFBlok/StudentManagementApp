using System.ComponentModel.DataAnnotations;

namespace StudentManagementApp.Data
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Course is required")]
        [StringLength(50, ErrorMessage = "Course name cannot exceed 50 characters")]
        public string Course { get; set; }

    }
}
