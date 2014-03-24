using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_icc_detailMap : EntityTypeConfiguration<sdb_icc_detail>
    {
        public sdb_icc_detailMap()
        {
            // Primary Key
            this.HasKey(t => t.detail_id);

            // Properties
            this.Property(t => t.detail_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.info_text)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.url)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("sdb_icc_detail");
            this.Property(t => t.detail_id).HasColumnName("detail_id");
            this.Property(t => t.icc_id).HasColumnName("icc_id");
            this.Property(t => t.info_text).HasColumnName("info_text");
            this.Property(t => t.url).HasColumnName("url");
        }
    }
}
