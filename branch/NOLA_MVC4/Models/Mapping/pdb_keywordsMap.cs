using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_keywordsMap : EntityTypeConfiguration<pdb_keywords>
    {
        public pdb_keywordsMap()
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
            this.ToTable("pdb_keywords");
            this.Property(t => t.keyword_name).HasColumnName("keyword_name");
            this.Property(t => t.keyword_id).HasColumnName("keyword_id");
        }
    }
}
