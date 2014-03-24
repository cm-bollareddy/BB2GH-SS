using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_form_dataMap : EntityTypeConfiguration<sdb_form_data>
    {
        public sdb_form_dataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_id, t.tab_type, t.nola_code, t.re_up });

            // Properties
            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.nola_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_notes)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("sdb_form_data");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.nola_code).HasColumnName("nola_code");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.pbs_notes).HasColumnName("pbs_notes");
        }
    }
}
