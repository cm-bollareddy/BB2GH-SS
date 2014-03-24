using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class epi_counterMap : EntityTypeConfiguration<epi_counter>
    {
        public epi_counterMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.pif_obdate, t.num_episodes, t.col4 });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.num_episodes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.col4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("epi_counter");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.pif_obdate).HasColumnName("pif_obdate");
            this.Property(t => t.num_episodes).HasColumnName("num_episodes");
            this.Property(t => t.col4).HasColumnName("col4");
        }
    }
}
