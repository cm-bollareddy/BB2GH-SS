using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tian_problem_typesMap : EntityTypeConfiguration<tian_problem_types>
    {
        public tian_problem_typesMap()
        {
            // Primary Key
            this.HasKey(t => t.problem_type);

            // Properties
            this.Property(t => t.problem_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.problem)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("tian_problem_types");
            this.Property(t => t.problem_type).HasColumnName("problem_type");
            this.Property(t => t.problem).HasColumnName("problem");
        }
    }
}
