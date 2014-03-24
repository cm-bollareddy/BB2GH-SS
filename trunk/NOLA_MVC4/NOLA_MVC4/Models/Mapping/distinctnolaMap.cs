using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class distinctnolaMap : EntityTypeConfiguration<distinctnola>
    {
        public distinctnolaMap()
        {
            // Primary Key
            this.HasKey(t => t.episodeslate);

            // Properties
            this.Property(t => t.episodeslate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("distinctnolas", "pdbnola");
            this.Property(t => t.episodeslate).HasColumnName("episodeslate");
        }
    }
}
