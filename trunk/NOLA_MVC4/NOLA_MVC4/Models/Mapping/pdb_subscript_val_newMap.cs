using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_subscript_val_newMap : EntityTypeConfiguration<pdb_subscript_val_new>
    {
        public pdb_subscript_val_newMap()
        {
            // Primary Key
            this.HasKey(t => t.subscript);

            // Properties
            this.Property(t => t.subscript)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.subscript_desc)
                .IsRequired()
                .HasMaxLength(45);

            this.Property(t => t.subscript_rpt_trans)
                .IsRequired()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("pdb_subscript_val_new");
            this.Property(t => t.subscript).HasColumnName("subscript");
            this.Property(t => t.subscript_desc).HasColumnName("subscript_desc");
            this.Property(t => t.subscript_rpt_trans).HasColumnName("subscript_rpt_trans");
        }
    }
}
