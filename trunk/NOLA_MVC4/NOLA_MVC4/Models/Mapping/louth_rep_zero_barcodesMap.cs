using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_rep_zero_barcodesMap : EntityTypeConfiguration<louth_rep_zero_barcodes>
    {
        public louth_rep_zero_barcodesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sequence_number, t.action, t.type, t.parent_id, t.element_number, t.labeltitle, t.userstr, t.soma, t.somb, t.somc, t.somd, t.dura, t.durb, t.durc, t.durd, t.boxid });

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.action)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.labeltitle)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.userstr)
                .IsRequired()
                .HasMaxLength(56);

            this.Property(t => t.soma)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.somb)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.somc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.somd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dura)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.durb)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.durc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.durd)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.boxid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_rep_zero_barcodes");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
            this.Property(t => t.action).HasColumnName("action");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.labeltitle).HasColumnName("labeltitle");
            this.Property(t => t.userstr).HasColumnName("userstr");
            this.Property(t => t.soma).HasColumnName("soma");
            this.Property(t => t.somb).HasColumnName("somb");
            this.Property(t => t.somc).HasColumnName("somc");
            this.Property(t => t.somd).HasColumnName("somd");
            this.Property(t => t.dura).HasColumnName("dura");
            this.Property(t => t.durb).HasColumnName("durb");
            this.Property(t => t.durc).HasColumnName("durc");
            this.Property(t => t.durd).HasColumnName("durd");
            this.Property(t => t.boxid).HasColumnName("boxid");
        }
    }
}
