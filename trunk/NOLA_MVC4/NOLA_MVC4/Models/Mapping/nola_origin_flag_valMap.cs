using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_origin_flag_valMap : EntityTypeConfiguration<nola_origin_flag_val>
    {
        public nola_origin_flag_valMap()
        {
            // Primary Key
            this.HasKey(t => t.origination_flag);

            // Properties
            this.Property(t => t.origination_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.origination_flag_desc)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("nola_origin_flag_val");
            this.Property(t => t.origination_flag).HasColumnName("origination_flag");
            this.Property(t => t.origination_flag_desc).HasColumnName("origination_flag_desc");
        }
    }
}
