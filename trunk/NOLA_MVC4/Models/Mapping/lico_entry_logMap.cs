using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_entry_logMap : EntityTypeConfiguration<lico_entry_log>
    {
        public lico_entry_logMap()
        {
            // Primary Key
            this.HasKey(t => new { t.control_number, t.episode_nola, t.date_entered });

            // Properties
            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("lico_entry_log");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
        }
    }
}
