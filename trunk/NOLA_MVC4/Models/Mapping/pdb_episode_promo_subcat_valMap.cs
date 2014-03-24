using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_episode_promo_subcat_valMap : EntityTypeConfiguration<pdb_episode_promo_subcat_val>
    {
        public pdb_episode_promo_subcat_valMap()
        {
            // Primary Key
            this.HasKey(t => t.subcat);

            // Properties
            this.Property(t => t.subcat)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.subcat_description)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("pdb_episode_promo_subcat_val");
            this.Property(t => t.subcat).HasColumnName("subcat");
            this.Property(t => t.subcat_description).HasColumnName("subcat_description");
        }
    }
}
