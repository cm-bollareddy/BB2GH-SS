using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rights_windowMap : EntityTypeConfiguration<pdb_rights_window>
    {
        public pdb_rights_windowMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola, t.re_up, t.record_type, t.window_number, t.rights_type, t.rel_tel, t.window_type, t.rights_start, t.rights_end, t.rights_years, t.rights_months, t.rights_weeks, t.rights_days, t.rights_notes });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.record_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.window_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rights_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.rel_tel)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.window_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rights_years)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rights_months)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rights_weeks)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rights_days)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rights_notes)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("pdb_rights_window");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.record_type).HasColumnName("record_type");
            this.Property(t => t.window_number).HasColumnName("window_number");
            this.Property(t => t.rights_type).HasColumnName("rights_type");
            this.Property(t => t.rel_tel).HasColumnName("rel_tel");
            this.Property(t => t.window_type).HasColumnName("window_type");
            this.Property(t => t.rights_start).HasColumnName("rights_start");
            this.Property(t => t.rights_end).HasColumnName("rights_end");
            this.Property(t => t.rights_years).HasColumnName("rights_years");
            this.Property(t => t.rights_months).HasColumnName("rights_months");
            this.Property(t => t.rights_weeks).HasColumnName("rights_weeks");
            this.Property(t => t.rights_days).HasColumnName("rights_days");
            this.Property(t => t.rights_notes).HasColumnName("rights_notes");
        }
    }
}
