using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class episode_bv_mapMap : EntityTypeConfiguration<episode_bv_map>
    {
        public episode_bv_mapMap()
        {
            // Primary Key
            this.HasKey(t => t.episode_nola);

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("episode_bv_map", "pdbnola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.ass_id).HasColumnName("ass_id");
        }
    }
}
