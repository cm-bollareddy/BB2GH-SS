using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_seg_info_subcatMap : EntityTypeConfiguration<pdb_seg_info_subcat>
    {
        public pdb_seg_info_subcatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.ep_seg_segment_number, t.ep_seg_subject_category });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.ep_seg_segment_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ep_seg_subject_category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("pdb_seg_info_subcat");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.ep_seg_segment_number).HasColumnName("ep_seg_segment_number");
            this.Property(t => t.ep_seg_subject_category).HasColumnName("ep_seg_subject_category");
        }
    }
}
