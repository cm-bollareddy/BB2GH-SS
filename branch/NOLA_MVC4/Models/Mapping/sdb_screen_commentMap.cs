using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_screen_commentMap : EntityTypeConfiguration<sdb_screen_comment>
    {
        public sdb_screen_commentMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.screen_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(600);

            // Table & Column Mappings
            this.ToTable("sdb_screen_comment");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.screen_comment).HasColumnName("screen_comment");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
