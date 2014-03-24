using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_uccMap : EntityTypeConfiguration<sdb_ucc>
    {
        public sdb_uccMap()
        {
            // Primary Key
            this.HasKey(t => t.ucc_id);

            // Properties
            this.Property(t => t.ucc_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contact)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.fax)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.preamble_video)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.preamble_audio)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("sdb_ucc");
            this.Property(t => t.ucc_id).HasColumnName("ucc_id");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.total_amount).HasColumnName("total_amount");
            this.Property(t => t.preamble_time).HasColumnName("preamble_time");
            this.Property(t => t.preamble_video).HasColumnName("preamble_video");
            this.Property(t => t.preamble_audio).HasColumnName("preamble_audio");
        }
    }
}
