using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class moms_distributorsMap : EntityTypeConfiguration<moms_distributors>
    {
        public moms_distributorsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.distributor_code, t.distributor_name, t.address1, t.address2, t.address3, t.phone, t.fax, t.account, t.su_drop, t.contact, t.terms, t.instruct1, t.instruct2, t.instruct3, t.note1, t.note2, t.note3, t.term_allow, t.disct_pct, t.disct_days, t.due_days });

            // Properties
            this.Property(t => t.distributor_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.distributor_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.address1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.address2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.address3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.fax)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            this.Property(t => t.account)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.su_drop)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.terms)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.instruct1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.instruct2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.instruct3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.note1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.note2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.note3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.term_allow)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.disct_pct)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.disct_days)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.due_days)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("moms_distributors");
            this.Property(t => t.distributor_code).HasColumnName("distributor_code");
            this.Property(t => t.distributor_name).HasColumnName("distributor_name");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.address3).HasColumnName("address3");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.account).HasColumnName("account");
            this.Property(t => t.su_drop).HasColumnName("su_drop");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.terms).HasColumnName("terms");
            this.Property(t => t.instruct1).HasColumnName("instruct1");
            this.Property(t => t.instruct2).HasColumnName("instruct2");
            this.Property(t => t.instruct3).HasColumnName("instruct3");
            this.Property(t => t.note1).HasColumnName("note1");
            this.Property(t => t.note2).HasColumnName("note2");
            this.Property(t => t.note3).HasColumnName("note3");
            this.Property(t => t.term_allow).HasColumnName("term_allow");
            this.Property(t => t.disct_pct).HasColumnName("disct_pct");
            this.Property(t => t.disct_days).HasColumnName("disct_days");
            this.Property(t => t.due_days).HasColumnName("due_days");
        }
    }
}
