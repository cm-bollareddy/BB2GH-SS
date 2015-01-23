using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods_ecfMap : EntityTypeConfiguration<pods_ecf>
    {
        public pods_ecfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ep_pif_nola, t.cast_fname, t.cast_lname, t.cast_role });

            // Properties
            this.Property(t => t.ep_pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.cast_fname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.cast_lname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.cast_role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.pif_or_ep)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pods_ecf", "pdbnola");
            this.Property(t => t.ep_pif_nola).HasColumnName("ep_pif_nola");
            this.Property(t => t.cast_fname).HasColumnName("cast_fname");
            this.Property(t => t.cast_lname).HasColumnName("cast_lname");
            this.Property(t => t.cast_role).HasColumnName("cast_role");
            this.Property(t => t.pif_or_ep).HasColumnName("pif_or_ep");
            this.Property(t => t.daily_timestamp).HasColumnName("daily_timestamp");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
