using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_iccMap : EntityTypeConfiguration<sdb_icc>
    {
        public sdb_iccMap()
        {
            // Primary Key
            this.HasKey(t => t.icc_id);

            // Properties
            this.Property(t => t.icc_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contact)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.on_air_announcement)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.video)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.audio)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.etv_data)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("sdb_icc");
            this.Property(t => t.icc_id).HasColumnName("icc_id");
            this.Property(t => t.contact).HasColumnName("contact");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.on_air_announcement).HasColumnName("on_air_announcement");
            this.Property(t => t.video).HasColumnName("video");
            this.Property(t => t.audio).HasColumnName("audio");
            this.Property(t => t.etv_data).HasColumnName("etv_data");
        }
    }
}
