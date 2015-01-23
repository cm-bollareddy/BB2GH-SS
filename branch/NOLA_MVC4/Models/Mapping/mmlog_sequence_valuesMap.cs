using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class mmlog_sequence_valuesMap : EntityTypeConfiguration<mmlog_sequence_values>
    {
        public mmlog_sequence_valuesMap()
        {
            // Primary Key
            this.HasKey(t => t.sequence_value);

            // Properties
            this.Property(t => t.sequence_value)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("mmlog_sequence_values");
            this.Property(t => t.sequence_value).HasColumnName("sequence_value");
        }
    }
}
