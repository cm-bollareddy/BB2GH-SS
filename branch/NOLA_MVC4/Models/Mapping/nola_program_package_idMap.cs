using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_program_package_idMap : EntityTypeConfiguration<nola_program_package_id>
    {
        public nola_program_package_idMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nola_version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(13);

            this.Property(t => t.version_revision)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.full_key)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("nola_program_package_id");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.nola_version).HasColumnName("nola_version");
            this.Property(t => t.version_revision).HasColumnName("version_revision");
            this.Property(t => t.pkg_id).HasColumnName("pkg_id");
            this.Property(t => t.revision_number).HasColumnName("revision_number");
            this.Property(t => t.full_key).HasColumnName("full_key");
        }
    }
}
