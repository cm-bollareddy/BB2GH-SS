using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_pdb_pifMap : EntityTypeConfiguration<ctr_pdb_pif>
    {
        public ctr_pdb_pifMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.season_number, t.pif_nola, t.re_up });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.season_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pif_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.season_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("ctr_pdb_pif");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.season_number).HasColumnName("season_number");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
        }
    }
}
