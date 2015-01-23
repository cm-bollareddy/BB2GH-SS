using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class caption_source_valMap : EntityTypeConfiguration<caption_source_val>
    {
        public caption_source_valMap()
        {
            // Primary Key
            this.HasKey(t => t.caption_source_code);

            // Properties
            this.Property(t => t.caption_source_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.caption_source_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("caption_source_val");
            this.Property(t => t.caption_source_code).HasColumnName("caption_source_code");
            this.Property(t => t.caption_source_desc).HasColumnName("caption_source_desc");
        }
    }
}
