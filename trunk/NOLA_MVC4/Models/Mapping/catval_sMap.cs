using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class catval_sMap : EntityTypeConfiguration<catval_s>
    {
        public catval_sMap()
        {
            // Primary Key
            this.HasKey(t => t.cv_code);

            // Properties
            this.Property(t => t.cv_code)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("catval_s");
            this.Property(t => t.cv_code).HasColumnName("cv_code");
            this.Property(t => t.database_no).HasColumnName("database_no");
            this.Property(t => t.transaction_id).HasColumnName("transaction_id");
            this.Property(t => t.sequence_no).HasColumnName("sequence_no");
            this.Property(t => t.trans_time).HasColumnName("trans_time");
            this.Property(t => t.distribution_time).HasColumnName("distribution_time");
            this.Property(t => t.in_archive).HasColumnName("in_archive");
            this.Property(t => t.dd_routing).HasColumnName("dd_routing");
            this.Property(t => t.trans_type).HasColumnName("trans_type");
            this.Property(t => t.dd_priority).HasColumnName("dd_priority");
            this.Property(t => t.new_key).HasColumnName("new_key");
            this.Property(t => t.old_database_no).HasColumnName("old_database_no");
            this.Property(t => t.old_transaction_id).HasColumnName("old_transaction_id");
            this.Property(t => t.old_sequence_no).HasColumnName("old_sequence_no");
        }
    }
}
