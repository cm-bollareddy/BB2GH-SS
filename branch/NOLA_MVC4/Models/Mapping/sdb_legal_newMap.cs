using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_legal_newMap : EntityTypeConfiguration<sdb_legal_new>
    {
        public sdb_legal_newMap()
        {
            // Primary Key
            this.HasKey(t => new { t.dea_id, t.indemnify_type });

            // Properties
            this.Property(t => t.dea_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.indemnify_type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ins_carrier)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ins_representative)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.source)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name_of_acceptor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.accepted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.paper_submission)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_legal_new");
            this.Property(t => t.legal_id).HasColumnName("legal_id");
            this.Property(t => t.dea_id).HasColumnName("dea_id");
            this.Property(t => t.indemnify_type).HasColumnName("indemnify_type");
            this.Property(t => t.ins_carrier).HasColumnName("ins_carrier");
            this.Property(t => t.ins_representative).HasColumnName("ins_representative");
            this.Property(t => t.source).HasColumnName("source");
            this.Property(t => t.ins_date).HasColumnName("ins_date");
            this.Property(t => t.name_of_acceptor).HasColumnName("name_of_acceptor");
            this.Property(t => t.entity_of_acceptor).HasColumnName("entity_of_acceptor");
            this.Property(t => t.accepted).HasColumnName("accepted");
            this.Property(t => t.paper_submission).HasColumnName("paper_submission");
        }
    }
}
