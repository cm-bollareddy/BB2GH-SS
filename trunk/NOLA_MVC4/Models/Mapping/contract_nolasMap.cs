using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_nolasMap : EntityTypeConfiguration<contract_nolas>
    {
        public contract_nolasMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.program_title)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("contract_nolas");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.soundex).HasColumnName("soundex");
        }
    }
}
