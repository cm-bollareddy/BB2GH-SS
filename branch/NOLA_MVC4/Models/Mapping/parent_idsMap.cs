using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class parent_idsMap : EntityTypeConfiguration<parent_ids>
    {
        public parent_idsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.@event_nola, t.reel_number, t.res_type });

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.res_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("parent_ids");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.res_type).HasColumnName("res_type");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
        }
    }
}
