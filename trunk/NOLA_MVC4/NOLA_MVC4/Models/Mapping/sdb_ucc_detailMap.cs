using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_ucc_detailMap : EntityTypeConfiguration<sdb_ucc_detail>
    {
        public sdb_ucc_detailMap()
        {
            // Primary Key
            this.HasKey(t => t.detail_id);

            // Properties
            this.Property(t => t.detail_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.funder_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.video)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.audio)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("sdb_ucc_detail");
            this.Property(t => t.detail_id).HasColumnName("detail_id");
            this.Property(t => t.ucc_id).HasColumnName("ucc_id");
            this.Property(t => t.funder_code).HasColumnName("funder_code");
            this.Property(t => t.time).HasColumnName("time");
            this.Property(t => t.video).HasColumnName("video");
            this.Property(t => t.audio).HasColumnName("audio");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.order_id).HasColumnName("order_id");
        }
    }
}
