using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pbs_promosMap : EntityTypeConfiguration<pbs_promos>
    {
        public pbs_promosMap()
        {
            // Primary Key
            this.HasKey(t => new { t.promo_reel, t.promo_cut });

            // Properties
            this.Property(t => t.promo_reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.promo_cut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.promo_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.request)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.revision)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pbs_promos");
            this.Property(t => t.promo_reel).HasColumnName("promo_reel");
            this.Property(t => t.promo_cut).HasColumnName("promo_cut");
            this.Property(t => t.promo_key).HasColumnName("promo_key");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.promo_id).HasColumnName("promo_id");
            this.Property(t => t.program_feed_date).HasColumnName("program_feed_date");
            this.Property(t => t.request).HasColumnName("request");
            this.Property(t => t.revision).HasColumnName("revision");
        }
    }
}
