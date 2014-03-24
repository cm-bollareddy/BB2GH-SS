using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_trans_status_valMap : EntityTypeConfiguration<nola_trans_status_val>
    {
        public nola_trans_status_valMap()
        {
            // Primary Key
            this.HasKey(t => t.status_number);

            // Properties
            this.Property(t => t.status_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.status_desc)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("nola_trans_status_val");
            this.Property(t => t.status_number).HasColumnName("status_number");
            this.Property(t => t.status_desc).HasColumnName("status_desc");
        }
    }
}
