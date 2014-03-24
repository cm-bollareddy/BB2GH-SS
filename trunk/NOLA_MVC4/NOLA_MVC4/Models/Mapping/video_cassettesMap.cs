using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class video_cassettesMap : EntityTypeConfiguration<video_cassettes>
    {
        public video_cassettesMap()
        {
            // Primary Key
            this.HasKey(t => t.program_number);

            // Properties
            this.Property(t => t.program_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.department)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.screener)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.title)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.other1_descript)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.other2_descript)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.contact_name)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.contact_company)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.contact_address)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.disposition)
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.disposition_other)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.comments)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("video_cassettes");
            this.Property(t => t.program_number).HasColumnName("program_number");
            this.Property(t => t.date_in_house).HasColumnName("date_in_house");
            this.Property(t => t.date_returned).HasColumnName("date_returned");
            this.Property(t => t.department).HasColumnName("department");
            this.Property(t => t.screener).HasColumnName("screener");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.half_no_reels).HasColumnName("half_no_reels");
            this.Property(t => t.half_no_copies).HasColumnName("half_no_copies");
            this.Property(t => t.threeq_no_reels).HasColumnName("threeq_no_reels");
            this.Property(t => t.threeq_no_copies).HasColumnName("threeq_no_copies");
            this.Property(t => t.other1_descript).HasColumnName("other1_descript");
            this.Property(t => t.other1_no_reels).HasColumnName("other1_no_reels");
            this.Property(t => t.other1_no_copies).HasColumnName("other1_no_copies");
            this.Property(t => t.other2_descript).HasColumnName("other2_descript");
            this.Property(t => t.other2_no_reels).HasColumnName("other2_no_reels");
            this.Property(t => t.other2_no_copies).HasColumnName("other2_no_copies");
            this.Property(t => t.contact_name).HasColumnName("contact_name");
            this.Property(t => t.contact_company).HasColumnName("contact_company");
            this.Property(t => t.contact_address).HasColumnName("contact_address");
            this.Property(t => t.contact_phone).HasColumnName("contact_phone");
            this.Property(t => t.disposition).HasColumnName("disposition");
            this.Property(t => t.disposition_other).HasColumnName("disposition_other");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
