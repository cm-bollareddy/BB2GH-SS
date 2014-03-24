using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_content_flagMap : EntityTypeConfiguration<pods2_pdb_content_flag>
    {
        public pods2_pdb_content_flagMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.@event_nola, t.pif_nola, t.flag_type, t.flag_time, t.flag_length, t.flag_description });

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

            this.Property(t => t.flag_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.flag_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.flag_description)
                .IsRequired()
                .HasMaxLength(710);

            // Table & Column Mappings
            this.ToTable("pods2_pdb_content_flag");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.flag_type).HasColumnName("flag_type");
            this.Property(t => t.flag_time).HasColumnName("flag_time");
            this.Property(t => t.flag_length).HasColumnName("flag_length");
            this.Property(t => t.flag_description).HasColumnName("flag_description");
        }
    }
}
