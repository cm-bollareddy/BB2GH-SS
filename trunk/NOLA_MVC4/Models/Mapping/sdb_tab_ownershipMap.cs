using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_tab_ownershipMap : EntityTypeConfiguration<sdb_tab_ownership>
    {
        public sdb_tab_ownershipMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_id, t.tab_type });

            // Properties
            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.operating_group)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sdb_tab_ownership");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.operating_group).HasColumnName("operating_group");
            this.Property(t => t.operating_unit).HasColumnName("operating_unit");
        }
    }
}
