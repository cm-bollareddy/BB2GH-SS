using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_prog_fillerMap : EntityTypeConfiguration<pdb_prog_filler>
    {
        public pdb_prog_fillerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.@event_nola, t.f_filler_number });

            // Properties
            this.Property(t => t.@event_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.f_filler_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.f_filler_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.f_integral_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.f_filler_comment)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.fil_description)
                .IsRequired()
                .HasMaxLength(375);

            // Table & Column Mappings
            this.ToTable("pdb_prog_filler");
            this.Property(t => t.@event_nola).HasColumnName("event_nola");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.f_filler_number).HasColumnName("f_filler_number");
            this.Property(t => t.f_filler_title).HasColumnName("f_filler_title");
            this.Property(t => t.f_filler_length).HasColumnName("f_filler_length");
            this.Property(t => t.f_integral_code).HasColumnName("f_integral_code");
            this.Property(t => t.f_filler_comment).HasColumnName("f_filler_comment");
            this.Property(t => t.fil_description).HasColumnName("fil_description");
        }
    }
}
