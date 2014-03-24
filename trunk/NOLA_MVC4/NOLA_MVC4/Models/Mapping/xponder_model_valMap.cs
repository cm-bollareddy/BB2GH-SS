using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class xponder_model_valMap : EntityTypeConfiguration<xponder_model_val>
    {
        public xponder_model_valMap()
        {
            // Primary Key
            this.HasKey(t => new { t.xponder_id, t.xponder_model });

            // Properties
            this.Property(t => t.xponder_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.xponder_model)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.created_by)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("xponder_model_val");
            this.Property(t => t.xponder_id).HasColumnName("xponder_id");
            this.Property(t => t.xponder_model).HasColumnName("xponder_model");
            this.Property(t => t.date_created).HasColumnName("date_created");
            this.Property(t => t.created_by).HasColumnName("created_by");
        }
    }
}
