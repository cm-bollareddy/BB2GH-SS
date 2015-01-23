using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class priority_valMap : EntityTypeConfiguration<priority_val>
    {
        public priority_valMap()
        {
            // Primary Key
            this.HasKey(t => t.priority);

            // Properties
            this.Property(t => t.priority)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.priority_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("priority_val");
            this.Property(t => t.priority).HasColumnName("priority");
            this.Property(t => t.priority_desc).HasColumnName("priority_desc");
        }
    }
}
