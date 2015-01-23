using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tian_twrsMap : EntityTypeConfiguration<tian_twrs>
    {
        public tian_twrsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.tian_number, t.twr_number });

            // Properties
            this.Property(t => t.tian_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tian_twrs");
            this.Property(t => t.tian_number).HasColumnName("tian_number");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
        }
    }
}
