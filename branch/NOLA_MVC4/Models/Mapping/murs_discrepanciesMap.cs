using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class murs_discrepanciesMap : EntityTypeConfiguration<murs_discrepancies>
    {
        public murs_discrepanciesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nola, t.pdb_length });

            // Properties
            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.pdb_length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("murs_discrepancies");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.total_length).HasColumnName("total_length");
            this.Property(t => t.pdb_length).HasColumnName("pdb_length");
        }
    }
}
