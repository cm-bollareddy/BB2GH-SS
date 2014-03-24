using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_non_legal_nolasMap : EntityTypeConfiguration<nola_non_legal_nolas>
    {
        public nola_non_legal_nolasMap()
        {
            // Primary Key
            this.HasKey(t => t.nola_excluded);

            // Properties
            this.Property(t => t.nola_excluded)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("nola_non_legal_nolas");
            this.Property(t => t.nola_excluded).HasColumnName("nola_excluded");
        }
    }
}
