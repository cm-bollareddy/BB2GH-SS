using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_workflow_templatesMap : EntityTypeConfiguration<sdb_workflow_templates>
    {
        public sdb_workflow_templatesMap()
        {
            // Primary Key
            this.HasKey(t => t.template_id);

            // Properties
            this.Property(t => t.template_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.filename)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.label)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.description)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sdb_workflow_templates");
            this.Property(t => t.template_id).HasColumnName("template_id");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.label).HasColumnName("label");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
