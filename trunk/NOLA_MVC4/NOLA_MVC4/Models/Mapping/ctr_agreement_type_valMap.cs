using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_agreement_type_valMap : EntityTypeConfiguration<ctr_agreement_type_val>
    {
        public ctr_agreement_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.agreement_abbreviation);

            // Properties
            this.Property(t => t.agreement_abbreviation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.agreement_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("ctr_agreement_type_val");
            this.Property(t => t.agreement_abbreviation).HasColumnName("agreement_abbreviation");
            this.Property(t => t.agreement_type).HasColumnName("agreement_type");
        }
    }
}
