using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_program_commitmentsMap : EntityTypeConfiguration<ctr_program_commitments>
    {
        public ctr_program_commitmentsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.contract_number, t.pgm_cmt_key });

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pgm_cmt_key)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fund_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("ctr_program_commitments");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.pgm_cmt_key).HasColumnName("pgm_cmt_key");
            this.Property(t => t.fund_name).HasColumnName("fund_name");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.year).HasColumnName("year");
        }
    }
}
