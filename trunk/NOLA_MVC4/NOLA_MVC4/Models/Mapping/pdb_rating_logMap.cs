using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rating_logMap : EntityTypeConfiguration<pdb_rating_log>
    {
        public pdb_rating_logMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.version_rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.version_subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pdb_rating_log");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.version_rating).HasColumnName("version_rating");
            this.Property(t => t.version_subrating).HasColumnName("version_subrating");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.state).HasColumnName("state");
        }
    }
}
