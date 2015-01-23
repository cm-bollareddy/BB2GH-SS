using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class next_louth_seqMap : EntityTypeConfiguration<next_louth_seq>
    {
        public next_louth_seqMap()
        {
            // Primary Key
            this.HasKey(t => t.sequence_number);

            // Properties
            this.Property(t => t.sequence_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("next_louth_seq");
            this.Property(t => t.sequence_number).HasColumnName("sequence_number");
        }
    }
}
