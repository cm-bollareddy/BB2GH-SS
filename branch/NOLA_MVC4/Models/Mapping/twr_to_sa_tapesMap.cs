using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_to_sa_tapesMap : EntityTypeConfiguration<twr_to_sa_tapes>
    {
        public twr_to_sa_tapesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.twr_number, t.item_no });

            // Properties
            this.Property(t => t.twr_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.item_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.mformat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.xact_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("twr_to_sa_tapes");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.item_no).HasColumnName("item_no");
            this.Property(t => t.mformat).HasColumnName("mformat");
            this.Property(t => t.shelf_location).HasColumnName("shelf_location");
            this.Property(t => t.xact_time).HasColumnName("xact_time");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
