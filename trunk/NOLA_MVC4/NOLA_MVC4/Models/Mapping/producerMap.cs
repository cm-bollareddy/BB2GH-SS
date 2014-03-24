using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class producerMap : EntityTypeConfiguration<producer>
    {
        public producerMap()
        {
            // Primary Key
            this.HasKey(t => t.pd_code);

            // Properties
            this.Property(t => t.pd_code)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.pd_name)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pd_addr1)
                .HasMaxLength(40);

            this.Property(t => t.pd_addr2)
                .HasMaxLength(40);

            this.Property(t => t.pd_addr3)
                .HasMaxLength(40);

            this.Property(t => t.pd_addr4)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("producer");
            this.Property(t => t.pd_code).HasColumnName("pd_code");
            this.Property(t => t.pd_name).HasColumnName("pd_name");
            this.Property(t => t.pd_addr1).HasColumnName("pd_addr1");
            this.Property(t => t.pd_addr2).HasColumnName("pd_addr2");
            this.Property(t => t.pd_addr3).HasColumnName("pd_addr3");
            this.Property(t => t.pd_addr4).HasColumnName("pd_addr4");
        }
    }
}
