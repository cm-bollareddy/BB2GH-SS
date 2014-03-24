using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class event_type_valMap : EntityTypeConfiguration<event_type_val>
    {
        public event_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.@event_type);

            // Properties
            this.Property(t => t.@event_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mnemonic)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("event_type_val");
            this.Property(t => t.@event_type).HasColumnName("event_type");
            this.Property(t => t.mnemonic).HasColumnName("mnemonic");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
