using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ancillary_counterMap : EntityTypeConfiguration<ancillary_counter>
    {
        public ancillary_counterMap()
        {
            // Primary Key
            this.HasKey(t => t.nola_root);

            // Properties
            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("ancillary_counter");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.next_episode).HasColumnName("next_episode");
        }
    }
}
