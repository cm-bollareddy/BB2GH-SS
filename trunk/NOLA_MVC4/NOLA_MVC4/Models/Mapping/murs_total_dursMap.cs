using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class murs_total_dursMap : EntityTypeConfiguration<murs_total_durs>
    {
        public murs_total_dursMap()
        {
            // Primary Key
            this.HasKey(t => t.nola);

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("murs_total_durs");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.total_length).HasColumnName("total_length");
        }
    }
}
