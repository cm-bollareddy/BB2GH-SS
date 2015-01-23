using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tian_problemsMap : EntityTypeConfiguration<tian_problems>
    {
        public tian_problemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tian_number, t.category, t.problem_number });

            // Properties
            this.Property(t => t.tian_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.category)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.problem_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.problem_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.problem_description)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("tian_problems");
            this.Property(t => t.tian_number).HasColumnName("tian_number");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.problem_number).HasColumnName("problem_number");
            this.Property(t => t.problem_type).HasColumnName("problem_type");
            this.Property(t => t.problem_description).HasColumnName("problem_description");
        }
    }
}
