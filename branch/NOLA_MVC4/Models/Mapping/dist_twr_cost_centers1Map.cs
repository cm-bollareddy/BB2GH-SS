using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class dist_twr_cost_centers1Map : EntityTypeConfiguration<dist_twr_cost_centers1>
    {
        public dist_twr_cost_centers1Map()
        {
            // Primary Key
            this.HasKey(t => t.cc_account_name);

            // Properties
            this.Property(t => t.el2)
                .HasMaxLength(13);

            this.Property(t => t.el3)
                .HasMaxLength(13);

            this.Property(t => t.el4)
                .HasMaxLength(13);

            this.Property(t => t.new_el4)
                .HasMaxLength(13);

            this.Property(t => t.cc_account_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("dist_twr_cost_centers1");
            this.Property(t => t.el2).HasColumnName("el2");
            this.Property(t => t.el3).HasColumnName("el3");
            this.Property(t => t.el4).HasColumnName("el4");
            this.Property(t => t.new_el4).HasColumnName("new_el4");
            this.Property(t => t.cc_account_number).HasColumnName("cc_account_number");
            this.Property(t => t.cc_account_name).HasColumnName("cc_account_name");
        }
    }
}
