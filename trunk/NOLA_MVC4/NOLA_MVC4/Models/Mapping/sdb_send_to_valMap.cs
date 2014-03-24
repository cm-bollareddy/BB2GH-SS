using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_send_to_valMap : EntityTypeConfiguration<sdb_send_to_val>
    {
        public sdb_send_to_valMap()
        {
            // Primary Key
            this.HasKey(t => t.send_to);

            // Properties
            this.Property(t => t.send_to)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sdb_send_to_val");
            this.Property(t => t.send_to).HasColumnName("send_to");
            this.Property(t => t.label).HasColumnName("label");
        }
    }
}
