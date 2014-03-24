using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_pbs_record_valMap : EntityTypeConfiguration<pdb_pbs_record_val>
    {
        public pdb_pbs_record_valMap()
        {
            // Primary Key
            this.HasKey(t => t.pbs_record);

            // Properties
            this.Property(t => t.pbs_record)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("pdb_pbs_record_val");
            this.Property(t => t.pbs_record).HasColumnName("pbs_record");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
