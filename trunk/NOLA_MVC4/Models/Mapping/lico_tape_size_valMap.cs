using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_tape_size_valMap : EntityTypeConfiguration<lico_tape_size_val>
    {
        public lico_tape_size_valMap()
        {
            // Primary Key
            this.HasKey(t => t.tape_size);

            // Properties
            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.size_description)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("lico_tape_size_val");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.size_description).HasColumnName("size_description");
        }
    }
}
