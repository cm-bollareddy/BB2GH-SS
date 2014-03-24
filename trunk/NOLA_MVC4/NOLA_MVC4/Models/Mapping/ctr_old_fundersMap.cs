using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_old_fundersMap : EntityTypeConfiguration<ctr_old_funders>
    {
        public ctr_old_fundersMap()
        {
            // Primary Key
            this.HasKey(t => t.funder_code);

            // Properties
            this.Property(t => t.funder_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("ctr_old_funders");
            this.Property(t => t.funder_code).HasColumnName("funder_code");
        }
    }
}
