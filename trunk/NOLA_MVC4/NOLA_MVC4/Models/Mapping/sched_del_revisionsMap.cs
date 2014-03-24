using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_del_revisionsMap : EntityTypeConfiguration<sched_del_revisions>
    {
        public sched_del_revisionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_index, t.sdr_key });

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sdr_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("sched_del_revisions");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sdr_key).HasColumnName("sdr_key");
            this.Property(t => t.flag_date_time).HasColumnName("flag_date_time");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
