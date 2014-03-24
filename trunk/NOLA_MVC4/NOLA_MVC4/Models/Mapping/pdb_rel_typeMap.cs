using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rel_typeMap : EntityTypeConfiguration<pdb_rel_type>
    {
        public pdb_rel_typeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rel_id, t.rel_type });

            // Properties
            this.Property(t => t.rel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rel_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("pdb_rel_type");
            this.Property(t => t.rel_id).HasColumnName("rel_id");
            this.Property(t => t.rel_type).HasColumnName("rel_type");
        }
    }
}
