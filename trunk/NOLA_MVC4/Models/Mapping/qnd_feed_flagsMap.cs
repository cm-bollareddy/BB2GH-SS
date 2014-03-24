using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class qnd_feed_flagsMap : EntityTypeConfiguration<qnd_feed_flags>
    {
        public qnd_feed_flagsMap()
        {
            // Primary Key
            this.HasKey(t => t.feed_flag);

            // Properties
            this.Property(t => t.feed_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.rec_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.rel_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("qnd_feed_flags");
            this.Property(t => t.feed_flag).HasColumnName("feed_flag");
            this.Property(t => t.rec_type).HasColumnName("rec_type");
            this.Property(t => t.rel_type).HasColumnName("rel_type");
        }
    }
}
