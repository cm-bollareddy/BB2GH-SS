using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_rel_typeMap : EntityTypeConfiguration<sdb_rel_type>
    {
        public sdb_rel_typeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rel_id, t.rel_type });

            // Properties
            this.Property(t => t.rel_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rel_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_rel_type");
            this.Property(t => t.rel_id).HasColumnName("rel_id");
            this.Property(t => t.rel_type).HasColumnName("rel_type");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
