using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class coda_cost_centersMap : EntityTypeConfiguration<coda_cost_centers>
    {
        public coda_cost_centersMap()
        {
            // Primary Key
            this.HasKey(t => t.cj_account);

            // Properties
            this.Property(t => t.cj_account)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.coda_account)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("coda_cost_centers");
            this.Property(t => t.cj_account).HasColumnName("cj_account");
            this.Property(t => t.cj_cost_center).HasColumnName("cj_cost_center");
            this.Property(t => t.coda_account).HasColumnName("coda_account");
            this.Property(t => t.coda_cost_center).HasColumnName("coda_cost_center");
        }
    }
}
