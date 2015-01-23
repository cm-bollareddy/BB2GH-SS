using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class dist_twr_cost_centers_newMap : EntityTypeConfiguration<dist_twr_cost_centers_new>
    {
        public dist_twr_cost_centers_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.old4, t.old2, t.old3, t.new4 });

            // Properties
            this.Property(t => t.old4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.old2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.old3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.new4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("dist_twr_cost_centers_new");
            this.Property(t => t.old4).HasColumnName("old4");
            this.Property(t => t.old2).HasColumnName("old2");
            this.Property(t => t.old3).HasColumnName("old3");
            this.Property(t => t.new4).HasColumnName("new4");
        }
    }
}
