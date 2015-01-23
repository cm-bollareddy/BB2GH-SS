using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_version_credit_textMap : EntityTypeConfiguration<pdb_version_credit_text>
    {
        public pdb_version_credit_textMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_nola);

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.credit_text)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("pdb_version_credit_text");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.credit_text).HasColumnName("credit_text");
        }
    }
}
