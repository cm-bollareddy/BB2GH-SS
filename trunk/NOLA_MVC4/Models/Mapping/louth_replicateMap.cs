using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_replicateMap : EntityTypeConfiguration<louth_replicate>
    {
        public louth_replicateMap()
        {
            // Primary Key
            this.HasKey(t => t.sequence_number);

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.action)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.labeltitle)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.userstr)
                .IsRequired()
                .HasMaxLength(56);

            // Table & Column Mappings
            this.ToTable("louth_replicate");
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
            this.Property(t => t.created).HasColumnName("created");
        }
    }
}
