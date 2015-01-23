using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_cast_role_valMap : EntityTypeConfiguration<pdb_cast_role_val>
    {
        public pdb_cast_role_valMap()
        {
            // Primary Key
            this.HasKey(t => t.role);

            // Properties
            this.Property(t => t.role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.role_description)
                .IsRequired()
                .HasMaxLength(26);

            // Table & Column Mappings
            this.ToTable("pdb_cast_role_val");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.role_description).HasColumnName("role_description");
        }
    }
}
