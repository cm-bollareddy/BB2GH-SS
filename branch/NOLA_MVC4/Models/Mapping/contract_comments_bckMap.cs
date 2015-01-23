using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_comments_bckMap : EntityTypeConfiguration<contract_comments_bck>
    {
        public contract_comments_bckMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.contract_comment });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contract_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("contract_comments_bck");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.contract_comment).HasColumnName("contract_comment");
        }
    }
}
