using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_cue_assocMap : EntityTypeConfiguration<louth_cue_assoc>
    {
        public louth_cue_assocMap()
        {
            // Primary Key
            this.HasKey(t => new { t.before_surr, t.before });

            // Properties
            this.Property(t => t.before_surr)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.before)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("louth_cue_assoc");
            this.Property(t => t.before_surr).HasColumnName("before_surr");
            this.Property(t => t.before).HasColumnName("before");
        }
    }
}
