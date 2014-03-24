using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_shelvesMap : EntityTypeConfiguration<lico_shelves>
    {
        public lico_shelvesMap()
        {
            // Primary Key
            this.HasKey(t => t.shelf_number);

            // Properties
            this.Property(t => t.shelf_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.location)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("lico_shelves");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.rack).HasColumnName("rack");
            this.Property(t => t.shelf).HasColumnName("shelf");
            this.Property(t => t.space).HasColumnName("space");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.location).HasColumnName("location");
        }
    }
}
