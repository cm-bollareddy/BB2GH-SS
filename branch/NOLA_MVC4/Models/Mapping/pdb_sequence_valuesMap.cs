using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_sequence_valuesMap : EntityTypeConfiguration<pdb_sequence_values>
    {
        public pdb_sequence_valuesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.sequence_owner, t.sequence_table, t.sequence_column });

            // Properties
            this.Property(t => t.sequence_owner)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sequence_table)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.sequence_column)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("pdb_sequence_values");
            this.Property(t => t.sequence_owner).HasColumnName("sequence_owner");
            this.Property(t => t.sequence_table).HasColumnName("sequence_table");
            this.Property(t => t.sequence_column).HasColumnName("sequence_column");
            this.Property(t => t.sequence_value).HasColumnName("sequence_value");
        }
    }
}
