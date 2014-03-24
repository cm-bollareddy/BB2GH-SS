using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class contract_commentsMap : EntityTypeConfiguration<contract_comments>
    {
        public contract_commentsMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contract_comment)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("contract_comments");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.contract_comment).HasColumnName("contract_comment");
        }
    }
}
