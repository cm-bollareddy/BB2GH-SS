using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_rundown_report_tapesMap : EntityTypeConfiguration<louth_rundown_report_tapes>
    {
        public louth_rundown_report_tapesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_index, t.reel_number, t.control_number, t.mb, t.tape_size });

            // Properties
            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("louth_rundown_report_tapes");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
        }
    }
}
