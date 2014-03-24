using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_program_serviceMap : EntityTypeConfiguration<sdb_program_service>
    {
        public sdb_program_serviceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.prog_serv });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prog_serv)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_program_service");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.prog_serv).HasColumnName("prog_serv");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
