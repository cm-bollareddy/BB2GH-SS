using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class l_dtmf_typeMap : EntityTypeConfiguration<l_dtmf_type>
    {
        public l_dtmf_typeMap()
        {
            // Primary Key
            this.HasKey(t => t.dtmf_type);

            // Properties
            this.Property(t => t.dtmf_type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("l_dtmf_type");
            this.Property(t => t.dtmf_type).HasColumnName("dtmf_type");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
