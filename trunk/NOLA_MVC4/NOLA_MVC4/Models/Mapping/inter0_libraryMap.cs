using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class inter0_libraryMap : EntityTypeConfiguration<inter0_library>
    {
        public inter0_libraryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.start_date, t.end_date, t.dow, t.type, t.nolachoice, t.element_number });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.dow)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.nolachoice)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("inter0_library");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_date).HasColumnName("start_date");
            this.Property(t => t.end_date).HasColumnName("end_date");
            this.Property(t => t.dow).HasColumnName("dow");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.nolachoice).HasColumnName("nolachoice");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
