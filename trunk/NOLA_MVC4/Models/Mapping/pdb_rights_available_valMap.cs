using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rights_available_valMap : EntityTypeConfiguration<pdb_rights_available_val>
    {
        public pdb_rights_available_valMap()
        {
            // Primary Key
            this.HasKey(t => t.rights_available);

            // Properties
            this.Property(t => t.rights_available)
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
            this.ToTable("pdb_rights_available_val");
            this.Property(t => t.rights_available).HasColumnName("rights_available");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
