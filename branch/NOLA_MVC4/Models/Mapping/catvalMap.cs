using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class catvalMap : EntityTypeConfiguration<catval>
    {
        public catvalMap()
        {
            // Primary Key
            this.HasKey(t => t.cv_code);

            // Properties
            this.Property(t => t.cv_code)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.cv_desc)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("catval");
            this.Property(t => t.cv_code).HasColumnName("cv_code");
            this.Property(t => t.cv_desc).HasColumnName("cv_desc");
        }
    }
}
