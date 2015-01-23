using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rating_log_aMap : EntityTypeConfiguration<pdb_rating_log_a>
    {
        public pdb_rating_log_aMap()
        {
            // Primary Key
            this.HasKey(t => new { t.@event_nola, t.start_time, t.state, t.timestamp, t.version_rating, t.version_subrating, t.database_no, t.transaction_id, t.sequence_no });

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.version_rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.version_subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.database_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.transaction_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sequence_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pdb_rating_log_a");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.timestamp).HasColumnName("timestamp");
            this.Property(t => t.version_rating).HasColumnName("version_rating");
            this.Property(t => t.version_subrating).HasColumnName("version_subrating");
            this.Property(t => t.database_no).HasColumnName("database_no");
            this.Property(t => t.transaction_id).HasColumnName("transaction_id");
            this.Property(t => t.sequence_no).HasColumnName("sequence_no");
        }
    }
}
