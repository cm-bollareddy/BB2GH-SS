using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rel_type_rec_type_mapMap : EntityTypeConfiguration<pdb_rel_type_rec_type_map>
    {
        public pdb_rel_type_rec_type_mapMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rel_type, t.rec_type });

            // Properties
            this.Property(t => t.rel_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.rec_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("pdb_rel_type_rec_type_map");
            this.Property(t => t.rel_type).HasColumnName("rel_type");
            this.Property(t => t.rec_type).HasColumnName("rec_type");
        }
    }
}
