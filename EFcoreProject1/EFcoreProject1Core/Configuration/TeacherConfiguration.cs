using EFcoreProject1Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreProject1Core.Configuration;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.Property(x => x.Salary).IsRequired().HasColumnType("DECIMAL(6,2)");  
        builder.HasOne(x => x.Course).WithMany(x => x.Teachers).HasForeignKey(x => x.CourseId).OnDelete(DeleteBehavior.Cascade);
    }
}
