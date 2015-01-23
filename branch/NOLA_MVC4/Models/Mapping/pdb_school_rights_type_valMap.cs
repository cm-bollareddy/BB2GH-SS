using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_school_rights_type_valMap : EntityTypeConfiguration<pdb_school_rights_type_val>
    {
        public pdb_school_rights_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.school_rights);

            // Properties
            this.Property(t => t.school_rights)
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
            this.ToTable("pdb_school_rights_type_val");
            this.Property(t => t.school_rights).HasColumnName("school_rights");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
