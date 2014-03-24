using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_dont_fireMap : EntityTypeConfiguration<louth_dont_fire>
    {
        public louth_dont_fireMap()
        {
            // Primary Key
            this.HasKey(t => t.session_id);

            // Properties
            this.Property(t => t.session_id)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("louth_dont_fire");
            this.Property(t => t.session_id).HasColumnName("session_id");
        }
    }
}
