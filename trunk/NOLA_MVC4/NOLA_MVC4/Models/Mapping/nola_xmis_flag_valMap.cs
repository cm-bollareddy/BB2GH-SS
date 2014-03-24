using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_xmis_flag_valMap : EntityTypeConfiguration<nola_xmis_flag_val>
    {
        public nola_xmis_flag_valMap()
        {
            // Primary Key
            this.HasKey(t => t.xmis_flag);

            // Properties
            this.Property(t => t.xmis_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xmis_flag_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("nola_xmis_flag_val");
            this.Property(t => t.xmis_flag).HasColumnName("xmis_flag");
            this.Property(t => t.xmis_flag_desc).HasColumnName("xmis_flag_desc");
        }
    }
}
