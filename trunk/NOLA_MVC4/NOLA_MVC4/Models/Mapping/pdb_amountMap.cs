using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_amountMap : EntityTypeConfiguration<pdb_amount>
    {
        public pdb_amountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.funder_code, t.record_type, t.pif_nola, t.re_up, t.season_nola, t.season_re_up, t.prod_acq_indicator, t.amount_funded, t.f_y_received, t.fund_credit, t.credit_begin_date, t.credit_end_date });

            // Properties
            this.Property(t => t.funder_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.record_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

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

            this.Property(t => t.season_re_up)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prod_acq_indicator)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.amount_funded)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.f_y_received)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fund_credit)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("pdb_amount");
            this.Property(t => t.funder_code).HasColumnName("funder_code");
            this.Property(t => t.record_type).HasColumnName("record_type");
            this.Property(t => t.pif_nola).HasColumnName("pif_nola");
            this.Property(t => t.re_up).HasColumnName("re_up");
            this.Property(t => t.season_nola).HasColumnName("season_nola");
            this.Property(t => t.season_re_up).HasColumnName("season_re_up");
            this.Property(t => t.prod_acq_indicator).HasColumnName("prod_acq_indicator");
            this.Property(t => t.amount_funded).HasColumnName("amount_funded");
            this.Property(t => t.f_y_received).HasColumnName("f_y_received");
            this.Property(t => t.fund_credit).HasColumnName("fund_credit");
            this.Property(t => t.credit_begin_date).HasColumnName("credit_begin_date");
            this.Property(t => t.credit_end_date).HasColumnName("credit_end_date");
        }
    }
}
