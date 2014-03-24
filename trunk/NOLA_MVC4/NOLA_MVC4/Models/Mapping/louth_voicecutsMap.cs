using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_voicecutsMap : EntityTypeConfiguration<louth_voicecuts>
    {
        public louth_voicecutsMap()
        {
            // Primary Key
            this.HasKey(t => t.cutroot);

            // Properties
            this.Property(t => t.cutroot)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("louth_voicecuts");
            this.Property(t => t.cutroot).HasColumnName("cutroot");
        }
    }
}
