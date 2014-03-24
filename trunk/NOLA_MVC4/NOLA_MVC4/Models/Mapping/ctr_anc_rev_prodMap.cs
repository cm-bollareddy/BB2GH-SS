using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_anc_rev_prodMap : EntityTypeConfiguration<ctr_anc_rev_prod>
    {
        public ctr_anc_rev_prodMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.prod_contact_fname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.prod_contact_lname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.prod_address_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.prod_address_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.prod_address_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.prod_city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.prod_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.prod_zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.prod_voice_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.prod_voice_ext)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("ctr_anc_rev_prod");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.prod_contact_fname).HasColumnName("prod_contact_fname");
            this.Property(t => t.prod_contact_lname).HasColumnName("prod_contact_lname");
            this.Property(t => t.prod_address_1).HasColumnName("prod_address_1");
            this.Property(t => t.prod_address_2).HasColumnName("prod_address_2");
            this.Property(t => t.prod_address_3).HasColumnName("prod_address_3");
            this.Property(t => t.prod_city).HasColumnName("prod_city");
            this.Property(t => t.prod_state).HasColumnName("prod_state");
            this.Property(t => t.prod_zip).HasColumnName("prod_zip");
            this.Property(t => t.prod_voice_phone).HasColumnName("prod_voice_phone");
            this.Property(t => t.prod_voice_ext).HasColumnName("prod_voice_ext");
        }
    }
}
