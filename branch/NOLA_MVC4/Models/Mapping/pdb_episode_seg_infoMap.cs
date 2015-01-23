using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_episode_seg_infoMap : EntityTypeConfiguration<pdb_episode_seg_info>
    {
        public pdb_episode_seg_infoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.ep_seg_segment_number });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.include_in_reports)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ep_seg_segment_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ep_seg_prog_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ep_seg_description)
                .IsRequired()
                .HasMaxLength(1700);

            // Table & Column Mappings
            this.ToTable("pdb_episode_seg_info");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.include_in_reports).HasColumnName("include_in_reports");
            this.Property(t => t.ep_seg_segment_number).HasColumnName("ep_seg_segment_number");
            this.Property(t => t.ep_seg_prog_type).HasColumnName("ep_seg_prog_type");
            this.Property(t => t.ep_seg_segment_length).HasColumnName("ep_seg_segment_length");
            this.Property(t => t.ep_seg_description).HasColumnName("ep_seg_description");
        }
    }
}
