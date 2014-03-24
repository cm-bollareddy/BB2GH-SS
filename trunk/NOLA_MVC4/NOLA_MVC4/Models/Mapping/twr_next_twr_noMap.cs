using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_next_twr_noMap : EntityTypeConfiguration<twr_next_twr_no>
    {
        public twr_next_twr_noMap()
        {
            // Primary Key
            this.HasKey(t => t.next_twr_number);

            // Properties
            this.Property(t => t.next_twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("twr_next_twr_no");
            this.Property(t => t.next_twr_number).HasColumnName("next_twr_number");
        }
    }
}
