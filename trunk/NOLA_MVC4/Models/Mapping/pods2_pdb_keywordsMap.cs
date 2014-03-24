using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pods2_pdb_keywordsMap : EntityTypeConfiguration<pods2_pdb_keywords>
    {
        public pods2_pdb_keywordsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.keyword_name, t.keyword_id });

            // Properties
            this.Property(t => t.keyword_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.keyword_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pods2_pdb_keywords");
            this.Property(t => t.keyword_name).HasColumnName("keyword_name");
            this.Property(t => t.keyword_id).HasColumnName("keyword_id");
        }
    }
}
