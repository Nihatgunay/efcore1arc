namespace EFcoreProject1Core.Models
{
    public class StudentTeacher
    {
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
