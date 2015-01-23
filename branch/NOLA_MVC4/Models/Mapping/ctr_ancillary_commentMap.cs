using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_ancillary_commentMap : EntityTypeConfiguration<ctr_ancillary_comment>
    {
        public ctr_ancillary_commentMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ancillary_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(72);

            // Table & Column Mappings
            this.ToTable("ctr_ancillary_comment");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.ancillary_comment).HasColumnName("ancillary_comment");
        }
    }
}
