using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rights_sMap : EntityTypeConfiguration<pdb_rights_s>
    {
        public pdb_rights_sMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pif_nola, t.re_up, t.record_type, t.window_number, t.database_no, t.transaction_id, t.sequence_no, t.in_archive, t.dd_routing, t.trans_type, t.dd_priority, t.new_key, t.old_database_no, t.old_transaction_id, t.old_sequence_no });

            // Properties
            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.record_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.window_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.database_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.transaction_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sequence_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.in_archive)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dd_routing)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.trans_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dd_priority)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.new_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.old_database_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.old_transaction_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.old_sequence_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pdb_rights_s");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.record_type).HasColumnName("record_type");
            this.Property(t => t.window_number).HasColumnName("window_number");
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
