using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_release_date_notesMap : EntityTypeConfiguration<sdb_release_date_notes>
    {
        public sdb_release_date_notesMap()
        {
            // Primary Key
            this.HasKey(t => t.release_date);

            // Properties
            this.Property(t => t.notes)
                .IsRequired()
                .HasMaxLength(1700);

            // Table & Column Mappings
            this.ToTable("sdb_release_date_notes");
            this.Property(t => t.release_date).HasColumnName("release_date");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
