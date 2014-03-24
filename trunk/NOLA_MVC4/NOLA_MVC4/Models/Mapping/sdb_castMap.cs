using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_castMap : EntityTypeConfiguration<sdb_cast>
    {
        public sdb_castMap()
        {
            // Primary Key
            this.HasKey(t => t.cast_key);

            // Properties
            this.Property(t => t.cast_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.fname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.fsoundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.lname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.lsoundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.suffix)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.role)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.cast_include_in_reports)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.cast_description)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("sdb_cast");
            this.Property(t => t.cast_key).HasColumnName("cast_key");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.fname).HasColumnName("fname");
            this.Property(t => t.fsoundex).HasColumnName("fsoundex");
            this.Property(t => t.lname).HasColumnName("lname");
            this.Property(t => t.lsoundex).HasColumnName("lsoundex");
            this.Property(t => t.suffix).HasColumnName("suffix");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.cast_include_in_reports).HasColumnName("cast_include_in_reports");
            this.Property(t => t.cast_description).HasColumnName("cast_description");
            this.Property(t => t.promotion_status).HasColumnName("promotion_status");
        }
    }
}
