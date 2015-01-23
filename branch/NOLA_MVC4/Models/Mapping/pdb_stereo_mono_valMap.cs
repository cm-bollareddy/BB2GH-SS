using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_stereo_mono_valMap : EntityTypeConfiguration<pdb_stereo_mono_val>
    {
        public pdb_stereo_mono_valMap()
        {
            // Primary Key
            this.HasKey(t => t.stereo_mono);

            // Properties
            this.Property(t => t.stereo_mono)
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
            this.ToTable("pdb_stereo_mono_val");
            this.Property(t => t.stereo_mono).HasColumnName("stereo_mono");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
