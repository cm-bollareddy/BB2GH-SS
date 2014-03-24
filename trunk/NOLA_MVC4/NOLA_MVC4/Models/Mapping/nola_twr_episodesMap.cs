using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_twr_episodesMap : EntityTypeConfiguration<nola_twr_episodes>
    {
        public nola_twr_episodesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.twr_number, t.nola_code });

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("nola_twr_episodes");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.nola_code).HasColumnName("nola_code");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.control_number).HasColumnName("control_number");
        }
    }
}
