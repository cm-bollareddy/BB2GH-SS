using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_rights_aMap : EntityTypeConfiguration<pdb_rights_a>
    {
        public pdb_rights_aMap()
        {
            // Primary Key
            this.HasKey(t => new { t.episode_nola, t.pif_nola, t.re_up, t.record_type, t.rights_end, t.rights_start, t.window_number, t.window_type, t.database_no, t.transaction_id, t.sequence_no });

            // Properties
            this.Property(t => t.episode_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

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

            this.Property(t => t.window_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.database_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.transaction_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sequence_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pdb_rights_a");
            this.Property(t => t.episode_nola).HasColumnName("episode_nola");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.record_type).HasColumnName("record_type");
            this.Property(t => t.rights_end).HasColumnName("rights_end");
            this.Property(t => t.rights_start).HasColumnName("rights_start");
            this.Property(t => t.window_number).HasColumnName("window_number");
            this.Property(t => t.window_type).HasColumnName("window_type");
            this.Property(t => t.database_no).HasColumnName("database_no");
            this.Property(t => t.transaction_id).HasColumnName("transaction_id");
            this.Property(t => t.sequence_no).HasColumnName("sequence_no");
        }
    }
}
