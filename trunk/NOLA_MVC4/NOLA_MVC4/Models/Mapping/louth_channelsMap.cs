using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_channelsMap : EntityTypeConfiguration<louth_channels>
    {
        public louth_channelsMap()
        {
            // Primary Key
            this.HasKey(t => t.mcr);

            // Properties
            this.Property(t => t.mcr)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.channel)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("louth_channels");
            this.Property(t => t.mcr).HasColumnName("mcr");
            this.Property(t => t.channel).HasColumnName("channel");
        }
    }
}
