using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class parent_ids_one_moreMap : EntityTypeConfiguration<parent_ids_one_more>
    {
        public parent_ids_one_moreMap()
        {
            // Primary Key
            this.HasKey(t => new { t.@event_nola, t.reel_number, t.parent_id });

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("parent_ids_one_more");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
        }
    }
}
