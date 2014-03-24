using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class tian_next_tian_noMap : EntityTypeConfiguration<tian_next_tian_no>
    {
        public tian_next_tian_noMap()
        {
            // Primary Key
            this.HasKey(t => t.next_tian_number);

            // Properties
            this.Property(t => t.next_tian_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tian_next_tian_no");
            this.Property(t => t.next_tian_number).HasColumnName("next_tian_number");
        }
    }
}
