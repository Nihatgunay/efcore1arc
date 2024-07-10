namespace EFcoreProject1Core.Models
{
    public class Course : IdName
    {
        public int Rating { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
