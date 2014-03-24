using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class delete_list_filterMap : EntityTypeConfiguration<delete_list_filter>
    {
        public delete_list_filterMap()
        {
            // Primary Key
            this.HasKey(t => t.nola_root);

            // Properties
            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("delete_list_filter");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
        }
    }
}
