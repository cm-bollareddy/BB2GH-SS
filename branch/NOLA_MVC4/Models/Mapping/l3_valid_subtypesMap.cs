using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_valid_subtypesMap : EntityTypeConfiguration<l3_valid_subtypes>
    {
        public l3_valid_subtypesMap()
        {
            // Primary Key
            this.HasKey(t => t.subtype);

            // Properties
            this.Property(t => t.subtype)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("l3_valid_subtypes");
            this.Property(t => t.subtype).HasColumnName("subtype");
        }
    }
}
