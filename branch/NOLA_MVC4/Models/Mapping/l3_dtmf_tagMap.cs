using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l3_dtmf_tagMap : EntityTypeConfiguration<l3_dtmf_tag>
    {
        public l3_dtmf_tagMap()
        {
            // Primary Key
            this.HasKey(t => t.dtmf_tag);

            // Properties
            this.Property(t => t.dtmf_tag)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("l3_dtmf_tag");
            this.Property(t => t.dtmf_tag).HasColumnName("dtmf_tag");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
