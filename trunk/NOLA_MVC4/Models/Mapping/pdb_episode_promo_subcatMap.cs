using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_episode_promo_subcatMap : EntityTypeConfiguration<pdb_episode_promo_subcat>
    {
        public pdb_episode_promo_subcatMap()
        {
            // Primary Key
            this.HasKey(t => t.pdb_promo_subcat_key);

            // Properties
            this.Property(t => t.pdb_promo_subcat_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("pdb_episode_promo_subcat");
            this.Property(t => t.pdb_promo_subcat_key).HasColumnName("pdb_promo_subcat_key");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.subject_category).HasColumnName("subject_category");
            this.Property(t => t.subject_category_type).HasColumnName("subject_category_type");
        }
    }
}
