using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_odedbmMap : EntityTypeConfiguration<louth_odedbm>
    {
        public louth_odedbmMap()
        {
            // Primary Key
            this.HasKey(t => new { t.house, t.element_number });

            // Properties
            this.Property(t => t.house)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.mb)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_odedbm");
            this.Property(t => t.house).HasColumnName("house");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.reel_number).HasColumnName("reel_number");
            this.Property(t => t.mb).HasColumnName("mb");
            this.Property(t => t.box).HasColumnName("box");
            this.Property(t => t.soma).HasColumnName("soma");
            this.Property(t => t.somb).HasColumnName("somb");
            this.Property(t => t.somc).HasColumnName("somc");
            this.Property(t => t.somd).HasColumnName("somd");
            this.Property(t => t.dura).HasColumnName("dura");
            this.Property(t => t.durb).HasColumnName("durb");
            this.Property(t => t.durc).HasColumnName("durc");
            this.Property(t => t.durd).HasColumnName("durd");
            this.Property(t => t.processed).HasColumnName("processed");
        }
    }
}
