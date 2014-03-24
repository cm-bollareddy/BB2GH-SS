using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_builder_journal_archiveMap : EntityTypeConfiguration<sched_builder_journal_archive>
    {
        public sched_builder_journal_archiveMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_index);

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.orig_sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("sched_builder_journal_archive");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.orig_sched_id).HasColumnName("orig_sched_id");
        }
    }
}
