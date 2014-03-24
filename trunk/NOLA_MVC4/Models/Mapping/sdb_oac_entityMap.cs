using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_oac_entityMap : EntityTypeConfiguration<sdb_oac_entity>
    {
        public sdb_oac_entityMap()
        {
            // Primary Key
            this.HasKey(t => t.entity_id);

            // Properties
            this.Property(t => t.entity_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.offeror)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fe_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fe_address)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fe_city)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fe_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.fe_zip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.message_audio)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.message_video)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.video_description)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.offer_made_by)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.payment_company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.payment_contact)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.payment_address)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.payment_city)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.payment_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.payment_zip)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.payment_phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.payment_fax)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.payment_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pre_pbs_logo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sdb_oac_entity");
            this.Property(t => t.entity_id).HasColumnName("entity_id");
            this.Property(t => t.oac_id).HasColumnName("oac_id");
            this.Property(t => t.offeror).HasColumnName("offeror");
            this.Property(t => t.fe_name).HasColumnName("fe_name");
            this.Property(t => t.fe_address).HasColumnName("fe_address");
            this.Property(t => t.fe_city).HasColumnName("fe_city");
            this.Property(t => t.fe_state).HasColumnName("fe_state");
            this.Property(t => t.fe_zip).HasColumnName("fe_zip");
            this.Property(t => t.message_audio).HasColumnName("message_audio");
            this.Property(t => t.message_video).HasColumnName("message_video");
            this.Property(t => t.video_description).HasColumnName("video_description");
            this.Property(t => t.offer_made_by).HasColumnName("offer_made_by");
            this.Property(t => t.payment_company).HasColumnName("payment_company");
            this.Property(t => t.payment_contact).HasColumnName("payment_contact");
            this.Property(t => t.payment_address).HasColumnName("payment_address");
            this.Property(t => t.payment_city).HasColumnName("payment_city");
            this.Property(t => t.payment_state).HasColumnName("payment_state");
            this.Property(t => t.payment_zip).HasColumnName("payment_zip");
            this.Property(t => t.payment_phone).HasColumnName("payment_phone");
            this.Property(t => t.payment_fax).HasColumnName("payment_fax");
            this.Property(t => t.payment_email).HasColumnName("payment_email");
            this.Property(t => t.message_length).HasColumnName("message_length");
            this.Property(t => t.pre_pbs_logo).HasColumnName("pre_pbs_logo");
        }
    }
}
