using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_device_namesMap : EntityTypeConfiguration<louth_device_names>
    {
        public louth_device_namesMap()
        {
            // Primary Key
            this.HasKey(t => t.device_name);

            // Properties
            this.Property(t => t.device_name)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("louth_device_names");
            this.Property(t => t.device_name).HasColumnName("device_name");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
