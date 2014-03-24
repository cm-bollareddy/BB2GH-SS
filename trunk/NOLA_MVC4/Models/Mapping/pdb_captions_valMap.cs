using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_captions_valMap : EntityTypeConfiguration<pdb_captions_val>
    {
        public pdb_captions_valMap()
        {
            // Primary Key
            this.HasKey(t => t.captions);

            // Properties
            this.Property(t => t.captions)
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
            this.ToTable("pdb_captions_val");
            this.Property(t => t.captions).HasColumnName("captions");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
