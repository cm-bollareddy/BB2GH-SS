using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tian_problem_type_valMap : EntityTypeConfiguration<tian_problem_type_val>
    {
        public tian_problem_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.problem_type);

            // Properties
            this.Property(t => t.problem_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.problem_type_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("tian_problem_type_val");
            this.Property(t => t.problem_type).HasColumnName("problem_type");
            this.Property(t => t.problem_type_description).HasColumnName("problem_type_description");
        }
    }
}
