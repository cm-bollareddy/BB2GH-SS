using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class catval_aMap : EntityTypeConfiguration<catval_a>
    {
        public catval_aMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cv_code, t.cv_desc, t.database_no, t.transaction_id, t.sequence_no });

            // Properties
            this.Property(t => t.cv_code)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.cv_desc)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.database_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.transaction_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sequence_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("catval_a");
            this.Property(t => t.cv_code).HasColumnName("cv_code");
            this.Property(t => t.cv_desc).HasColumnName("cv_desc");
            this.Property(t => t.database_no).HasColumnName("database_no");
            this.Property(t => t.transaction_id).HasColumnName("transaction_id");
            this.Property(t => t.sequence_no).HasColumnName("sequence_no");
        }
    }
}
