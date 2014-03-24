using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_control_numbersMap : EntityTypeConfiguration<twr_control_numbers>
    {
        public twr_control_numbersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.twr_number, t.control_number });

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.control_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("twr_control_numbers");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.control_number).HasColumnName("control_number");
        }
    }
}
