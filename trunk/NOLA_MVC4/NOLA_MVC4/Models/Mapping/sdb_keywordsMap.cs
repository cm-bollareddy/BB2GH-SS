using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_keywordsMap : EntityTypeConfiguration<sdb_keywords>
    {
        public sdb_keywordsMap()
        {
            // Primary Key
            this.HasKey(t => t.keyword_id);

            // Properties
            this.Property(t => t.keyword_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.keyword_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sdb_keywords");
            this.Property(t => t.keyword_name).HasColumnName("keyword_name");
            this.Property(t => t.keyword_id).HasColumnName("keyword_id");
        }
    }
}
