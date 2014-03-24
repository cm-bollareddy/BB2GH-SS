using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_distributor_valMap : EntityTypeConfiguration<nola_distributor_val>
    {
        public nola_distributor_valMap()
        {
            // Primary Key
            this.HasKey(t => t.distributor);

            // Properties
            this.Property(t => t.distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.distributor_rpt_trans)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.distributor_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.distributor_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.subdistributor_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.logo_location)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("nola_distributor_val");
            this.Property(t => t.distributor).HasColumnName("distributor");
            this.Property(t => t.distributor_group).HasColumnName("distributor_group");
            this.Property(t => t.distributor_rpt_trans).HasColumnName("distributor_rpt_trans");
            this.Property(t => t.distributor_name).HasColumnName("distributor_name");
            this.Property(t => t.distributor_status).HasColumnName("distributor_status");
            this.Property(t => t.operating_unit).HasColumnName("operating_unit");
            this.Property(t => t.subdistributor_flag).HasColumnName("subdistributor_flag");
            this.Property(t => t.logo_location).HasColumnName("logo_location");
        }
    }
}
