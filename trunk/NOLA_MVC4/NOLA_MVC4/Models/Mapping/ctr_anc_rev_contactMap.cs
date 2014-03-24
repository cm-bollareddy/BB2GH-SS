using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ctr_anc_rev_contactMap : EntityTypeConfiguration<ctr_anc_rev_contact>
    {
        public ctr_anc_rev_contactMap()
        {
            // Primary Key
            this.HasKey(t => t.contract_number);

            // Properties
            this.Property(t => t.contract_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contact_fname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contact_lname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contact_address_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.contact_address_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.contact_address_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(45);

            this.Property(t => t.contact_city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.contact_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.contact_zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.contact_voice_phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.contact_voice_ext)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("ctr_anc_rev_contact");
            this.Property(t => t.contract_number).HasColumnName("contract_number");
            this.Property(t => t.contact_fname).HasColumnName("contact_fname");
            this.Property(t => t.contact_lname).HasColumnName("contact_lname");
            this.Property(t => t.contact_address_1).HasColumnName("contact_address_1");
            this.Property(t => t.contact_address_2).HasColumnName("contact_address_2");
            this.Property(t => t.contact_address_3).HasColumnName("contact_address_3");
            this.Property(t => t.contact_city).HasColumnName("contact_city");
            this.Property(t => t.contact_state).HasColumnName("contact_state");
            this.Property(t => t.contact_zip).HasColumnName("contact_zip");
            this.Property(t => t.contact_voice_phone).HasColumnName("contact_voice_phone");
            this.Property(t => t.contact_voice_ext).HasColumnName("contact_voice_ext");
        }
    }
}
