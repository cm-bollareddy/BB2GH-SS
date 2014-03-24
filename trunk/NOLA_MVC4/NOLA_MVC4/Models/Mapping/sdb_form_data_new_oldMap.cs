using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_form_data_new_oldMap : EntityTypeConfiguration<sdb_form_data_new_old>
    {
        public sdb_form_data_new_oldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tab_id, t.tab_type, t.bv_id, t.label, t.pbs_notes });

            // Properties
            this.Property(t => t.tab_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.bv_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_notes)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("sdb_form_data_new_old");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
            this.Property(t => t.bv_id).HasColumnName("bv_id");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.pbs_notes).HasColumnName("pbs_notes");
        }
    }
}
