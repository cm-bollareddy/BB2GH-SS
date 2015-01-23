using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rightsMap : EntityTypeConfiguration<pdb_rights>
    {
        public pdb_rightsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.episode_nola, t.re_up, t.record_type, t.window_number, t.window_type, t.rights_start, t.rights_end });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.record_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.window_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.window_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pdb_rights");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.record_type).HasColumnName("record_type");
            this.Property(t => t.window_number).HasColumnName("window_number");
            this.Property(t => t.window_type).HasColumnName("window_type");
            this.Property(t => t.rights_start).HasColumnName("rights_start");
            this.Property(t => t.rights_end).HasColumnName("rights_end");
        }
    }
}
