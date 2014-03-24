using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tlico_xoutMap : EntityTypeConfiguration<tlico_xout>
    {
        public tlico_xoutMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.control_number, t.in_or_out, t.reel_number, t.mb, t.location, t.tape_size });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.root_episode)
                .HasMaxLength(12);

            this.Property(t => t.sub)
                .HasMaxLength(2);

            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_or_out)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.reel_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.mb)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.location)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("tlico_xout", "pdbnola");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.root_episode).HasColumnName("root_episode");
            this.Property(t => t.sub).HasColumnName("sub");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.in_or_out).HasColumnName("in_or_out");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
        }
    }
}
