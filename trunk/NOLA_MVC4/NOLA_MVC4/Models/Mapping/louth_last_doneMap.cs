using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_last_doneMap : EntityTypeConfiguration<louth_last_done>
    {
        public louth_last_doneMap()
        {
            // Primary Key
            this.HasKey(t => t.sequence_number);

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("louth_last_done");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
        }
    }
}
