using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_file_location_newMap : EntityTypeConfiguration<sdb_file_location_new>
    {
        public sdb_file_location_newMap()
        {
            // Primary Key
            this.HasKey(t => t.location_id);

            // Properties
            this.Property(t => t.location_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.filename)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.location)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.tab_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("sdb_file_location_new");
            this.Property(t => t.location_id).HasColumnName("location_id");
            this.Property(t => t.tab_id).HasColumnName("tab_id");
            this.Property(t => t.file_type).HasColumnName("file_type");
            this.Property(t => t.bv_id).HasColumnName("bv_id");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.tab_type).HasColumnName("tab_type");
        }
    }
}
