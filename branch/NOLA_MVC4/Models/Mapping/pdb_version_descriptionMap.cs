using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_version_descriptionMap : EntityTypeConfiguration<pdb_version_description>
    {
        public pdb_version_descriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.v_description)
                .IsRequired()
                .HasMaxLength(1560);

            // Table & Column Mappings
            this.ToTable("pdb_version_description");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.v_description).HasColumnName("v_description");
        }
    }
}
