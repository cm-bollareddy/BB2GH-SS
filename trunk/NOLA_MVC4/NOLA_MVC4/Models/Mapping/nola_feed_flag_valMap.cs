using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_feed_flag_valMap : EntityTypeConfiguration<nola_feed_flag_val>
    {
        public nola_feed_flag_valMap()
        {
            // Primary Key
            this.HasKey(t => t.feed_flag);

            // Properties
            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.feed_flag_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.feed_flag_rpt)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("nola_feed_flag_val");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.feed_flag_desc).HasColumnName("feed_flag_desc");
            this.Property(t => t.feed_flag_rpt).HasColumnName("feed_flag_rpt");
        }
    }
}
