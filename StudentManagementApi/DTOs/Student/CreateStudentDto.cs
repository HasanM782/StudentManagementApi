namespace StudentManagementApi.DTOs.Student
{
    public class CreateStudentDto
    {
        public string FullName { get; set; }
        public int Age { get; set; } 
        public string Email { get; set; }
        public int GroupId { get; set; }
    }
}
