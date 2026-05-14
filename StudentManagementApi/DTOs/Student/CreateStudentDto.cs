using System.ComponentModel.DataAnnotations;

namespace StudentManagementApi.DTOs.Student
{
    public class CreateStudentDto
    {
        [Required(ErrorMessage = "Full name is required.")]
        [MinLength(3 , ErrorMessage = "Full name must be at least 3 characters long.")]
        public string FullName { get; set; }

        [Range(16,60, ErrorMessage = "Age must be between 16 and 60.")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")] public string EmailAddress { get; set; }
        public string Email { get; set; }

        [Required (ErrorMessage = "Group ID is required.")]
        public int GroupId { get; set; }
    }
}
