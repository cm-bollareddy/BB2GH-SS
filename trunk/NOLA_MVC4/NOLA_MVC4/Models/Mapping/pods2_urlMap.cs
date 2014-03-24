using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_urlMap : EntityTypeConfiguration<pods2_url>
    {
        public pods2_urlMap()
        {
            // Primary Key
            this.HasKey(t => t.nola_root);

            // Properties
            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.url)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("pods2_url");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.url).HasColumnName("url");
        }
    }
}
