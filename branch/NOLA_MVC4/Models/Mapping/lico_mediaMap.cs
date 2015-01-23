using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_mediaMap : EntityTypeConfiguration<lico_media>
    {
        public lico_mediaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.parent_id, t.element_number, t.res_type });

            // Properties
            this.Property(t => t.parent_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.element_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.res_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.filename)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("lico_media");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.element_number).HasColumnName("element_number");
            this.Property(t => t.res_type).HasColumnName("res_type");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.create_date).HasColumnName("create_date");
        }
    }
}
