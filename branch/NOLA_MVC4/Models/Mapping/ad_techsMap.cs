using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ad_techsMap : EntityTypeConfiguration<ad_techs>
    {
        public ad_techsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ad_tech_key, t.discrepancy_number, t.technician_name, t.technician_assignment });

            // Properties
            this.Property(t => t.ad_tech_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.discrepancy_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.technician_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.technician_assignment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("ad_techs");
            this.Property(t => t.ad_tech_key).HasColumnName("ad_tech_key");
            this.Property(t => t.discrepancy_number).HasColumnName("discrepancy_number");
            this.Property(t => t.technician_name).HasColumnName("technician_name");
            this.Property(t => t.technician_assignment).HasColumnName("technician_assignment");
        }
    }
}
