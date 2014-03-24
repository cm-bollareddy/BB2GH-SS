using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_program_service_valMap : EntityTypeConfiguration<pdb_program_service_val>
    {
        public pdb_program_service_valMap()
        {
            // Primary Key
            this.HasKey(t => t.prog_serv);

            // Properties
            this.Property(t => t.prog_serv)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.pserv_description)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("pdb_program_service_val");
            this.Property(t => t.prog_serv).HasColumnName("prog_serv");
            this.Property(t => t.pserv_description).HasColumnName("pserv_description");
        }
    }
}
