using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_valid_supertypesMap : EntityTypeConfiguration<l3_valid_supertypes>
    {
        public l3_valid_supertypesMap()
        {
            // Primary Key
            this.HasKey(t => t.supertype);

            // Properties
            this.Property(t => t.supertype)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l3_valid_supertypes");
            this.Property(t => t.supertype).HasColumnName("supertype");
        }
    }
}
