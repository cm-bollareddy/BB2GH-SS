using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class anc_prog_grp_valMap : EntityTypeConfiguration<anc_prog_grp_val>
    {
        public anc_prog_grp_valMap()
        {
            // Primary Key
            this.HasKey(t => t.group_code);

            // Properties
            this.Property(t => t.group_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.group_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("anc_prog_grp_val");
            this.Property(t => t.group_code).HasColumnName("group_code");
            this.Property(t => t.group_name).HasColumnName("group_name");
        }
    }
}
