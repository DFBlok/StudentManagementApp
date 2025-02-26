using System.ComponentModel.DataAnnotations;

namespace StudentManagementApp.Data
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        [Required]

        public string Course { get; set; }

    }
}
