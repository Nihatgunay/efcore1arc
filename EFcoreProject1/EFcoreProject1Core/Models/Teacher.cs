namespace EFcoreProject1Core.Models
{
    public class Teacher : IdName
    {
        public double Salary { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<StudentTeacher> StudentsTeachers { get; set; }
    }
}
