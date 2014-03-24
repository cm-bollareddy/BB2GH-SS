using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rights_type_valMap : EntityTypeConfiguration<pdb_rights_type_val>
    {
        public pdb_rights_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.rights_type);

            // Properties
            this.Property(t => t.rights_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pbs_rights)
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
            this.ToTable("pdb_rights_type_val");
            this.Property(t => t.rights_type).HasColumnName("rights_type");
            this.Property(t => t.pbs_rights).HasColumnName("pbs_rights");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
