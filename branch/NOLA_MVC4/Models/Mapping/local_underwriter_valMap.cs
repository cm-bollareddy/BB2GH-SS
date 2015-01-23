using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class local_underwriter_valMap : EntityTypeConfiguration<local_underwriter_val>
    {
        public local_underwriter_valMap()
        {
            // Primary Key
            this.HasKey(t => t.lu_code);

            // Properties
            this.Property(t => t.lu_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.lu_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("local_underwriter_val");
            this.Property(t => t.lu_code).HasColumnName("lu_code");
            this.Property(t => t.lu_description).HasColumnName("lu_description");
        }
    }
}
