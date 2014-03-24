using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class prog_multi_reelsMap : EntityTypeConfiguration<prog_multi_reels>
    {
        public prog_multi_reelsMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("prog_multi_reels");
            this.Property(t => t.nola).HasColumnName("nola");
        }
    }
}
