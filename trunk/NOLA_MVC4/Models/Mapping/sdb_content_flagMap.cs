using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_content_flagMap : EntityTypeConfiguration<sdb_content_flag>
    {
        public sdb_content_flagMap()
        {
            // Primary Key
            this.HasKey(t => t.content_flag_id);

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.flag_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.flag_description)
                .IsRequired()
                .HasMaxLength(710);

            this.Property(t => t.content_flag_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_content_flag");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.flag_type).HasColumnName("flag_type");
            this.Property(t => t.flag_time).HasColumnName("flag_time");
            this.Property(t => t.flag_length).HasColumnName("flag_length");
            this.Property(t => t.flag_description).HasColumnName("flag_description");
            this.Property(t => t.content_flag_id).HasColumnName("content_flag_id");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
