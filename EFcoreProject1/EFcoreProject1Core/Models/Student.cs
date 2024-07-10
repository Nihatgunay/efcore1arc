namespace EFcoreProject1Core.Models
{
    public class Student : IdName
    {
        public double Grade { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<StudentTeacher> StudentsTeachers { get; set; }

    }
}
