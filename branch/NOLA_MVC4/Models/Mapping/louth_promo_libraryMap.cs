using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_promo_libraryMap : EntityTypeConfiguration<louth_promo_library>
    {
        public louth_promo_libraryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sched_id, t.promo_root, t.start_date, t.end_date, t.nolachoice, t.element_number });

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.promo_root)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.nolachoice)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_promo_library");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.promo_root).HasColumnName("promo_root");
            this.Property(t => t.start_date).HasColumnName("start_date");
            this.Property(t => t.end_date).HasColumnName("end_date");
            this.Property(t => t.nolachoice).HasColumnName("nolachoice");
            this.Property(t => t.element_number).HasColumnName("element_number");
        }
    }
}
