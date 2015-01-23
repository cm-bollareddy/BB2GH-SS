using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_instructionsMap : EntityTypeConfiguration<twr_instructions>
    {
        public twr_instructionsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.username, t.instruction_code, t.rate_type, t.rate_code, t.quantifier, t.instructions });

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.instruction_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.rate_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.rate_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.quantifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.instructions)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("twr_instructions");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.instruction_code).HasColumnName("instruction_code");
            this.Property(t => t.rate_type).HasColumnName("rate_type");
            this.Property(t => t.rate_code).HasColumnName("rate_code");
            this.Property(t => t.quantifier).HasColumnName("quantifier");
            this.Property(t => t.instructions).HasColumnName("instructions");
        }
    }
}
