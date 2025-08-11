using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem_assignmet.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }
    }

}
