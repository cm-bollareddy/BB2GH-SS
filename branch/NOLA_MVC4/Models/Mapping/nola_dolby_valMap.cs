using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_dolby_valMap : EntityTypeConfiguration<nola_dolby_val>
    {
        public nola_dolby_valMap()
        {
            // Primary Key
            this.HasKey(t => t.dolby);

            // Properties
            this.Property(t => t.dolby)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.dolby_desc)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("nola_dolby_val");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.dolby_desc).HasColumnName("dolby_desc");
        }
    }
}
