using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class promoMap : EntityTypeConfiguration<promo>
    {
        public promoMap()
        {
            // Primary Key
            this.HasKey(t => t.promo_key);

            // Properties
            this.Property(t => t.promo_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.promo_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.promo_reel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.location)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.producer_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.length_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.reel_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.outcue)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.endcue)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.tech_notes)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.comment)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.mention)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.note)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.stereo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.gen)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("promos");
            this.Property(t => t.promo_key).HasColumnName("promo_key");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.promo_id).HasColumnName("promo_id");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.cut_id).HasColumnName("cut_id");
            this.Property(t => t.promo_reel).HasColumnName("promo_reel");
            this.Property(t => t.promo_cut).HasColumnName("promo_cut");
            this.Property(t => t.arrival_date).HasColumnName("arrival_date");
            this.Property(t => t.departure_date).HasColumnName("departure_date");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.producer_code).HasColumnName("producer_code");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.length_indicator).HasColumnName("length_indicator");
            this.Property(t => t.tag).HasColumnName("tag");
            this.Property(t => t.reel_size).HasColumnName("reel_size");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.outcue).HasColumnName("outcue");
            this.Property(t => t.endcue).HasColumnName("endcue");
            this.Property(t => t.tech_notes).HasColumnName("tech_notes");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.mention).HasColumnName("mention");
            this.Property(t => t.note).HasColumnName("note");
            this.Property(t => t.stereo).HasColumnName("stereo");
            this.Property(t => t.gen).HasColumnName("gen");
        }
    }
}
