using EFcoreProject1Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject1Core.Configuration;

public class StudentTeacherConfiguration : IEntityTypeConfiguration<StudentTeacher>
{
    public void Configure(EntityTypeBuilder<StudentTeacher> builder)
    {
        builder.HasKey(st => new { st.StudentId, st.TeacherId }); //stack overflow//
        builder.HasOne(x => x.Student).WithMany(x => x.StudentsTeachers);    
        builder.HasOne(x => x.Teacher).WithMany(x => x.StudentsTeachers);
    }
}
