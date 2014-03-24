using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_dacs_journalMap : EntityTypeConfiguration<nola_dacs_journal>
    {
        public nola_dacs_journalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.date_generated, t.sched_date, t.dacs_filename, t.message_sent });

            // Properties
            this.Property(t => t.dacs_filename)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.message_sent)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_dacs_journal");
            this.Property(t => t.date_generated).HasColumnName("date_generated");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.dacs_filename).HasColumnName("dacs_filename");
            this.Property(t => t.message_sent).HasColumnName("message_sent");
        }
    }
}
