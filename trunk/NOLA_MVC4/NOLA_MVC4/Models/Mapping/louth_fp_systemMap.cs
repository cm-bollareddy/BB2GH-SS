using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_fp_systemMap : EntityTypeConfiguration<louth_fp_system>
    {
        public louth_fp_systemMap()
        {
            // Primary Key
            this.HasKey(t => t.system_id);

            // Properties
            this.Property(t => t.system_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.system)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("louth_fp_system");
            this.Property(t => t.system_id).HasColumnName("system_id");
            this.Property(t => t.system).HasColumnName("system");
        }
    }
}
