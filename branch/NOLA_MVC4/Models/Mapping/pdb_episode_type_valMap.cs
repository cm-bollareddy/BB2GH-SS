using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_episode_type_valMap : EntityTypeConfiguration<pdb_episode_type_val>
    {
        public pdb_episode_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.episode_type);

            // Properties
            this.Property(t => t.episode_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("pdb_episode_type_val");
            this.Property(t => t.episode_type).HasColumnName("episode_type");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
