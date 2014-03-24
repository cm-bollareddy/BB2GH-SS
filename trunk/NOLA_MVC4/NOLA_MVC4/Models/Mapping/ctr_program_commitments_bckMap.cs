using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_program_commitments_bckMap : EntityTypeConfiguration<ctr_program_commitments_bck>
    {
        public ctr_program_commitments_bckMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.pgm_cmt_key, t.fund_name, t.amount, t.year });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pgm_cmt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fund_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.amount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.year)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ctr_program_commitments_bck");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.pgm_cmt_key).HasColumnName("pgm_cmt_key");
            this.Property(t => t.fund_name).HasColumnName("fund_name");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.year).HasColumnName("year");
        }
    }
}
