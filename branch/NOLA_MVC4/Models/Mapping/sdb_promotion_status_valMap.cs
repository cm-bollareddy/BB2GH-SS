using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_promotion_status_valMap : EntityTypeConfiguration<sdb_promotion_status_val>
    {
        public sdb_promotion_status_valMap()
        {
            // Primary Key
            this.HasKey(t => t.promotion_status);

            // Properties
            this.Property(t => t.promotion_status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_promotion_status_val");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
