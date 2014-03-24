using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_seg_info_subcat_valMap : EntityTypeConfiguration<pdb_seg_info_subcat_val>
    {
        public pdb_seg_info_subcat_valMap()
        {
            // Primary Key
            this.HasKey(t => t.ep_seg_subject_category);

            // Properties
            this.Property(t => t.ep_seg_subject_category)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ep_seg_subject_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("pdb_seg_info_subcat_val");
            this.Property(t => t.ep_seg_subject_category).HasColumnName("ep_seg_subject_category");
            this.Property(t => t.ep_seg_subject_desc).HasColumnName("ep_seg_subject_desc");
        }
    }
}
