using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class als_edgeMap : EntityTypeConfiguration<als_edge>
    {
        public als_edgeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.unit_nola, t.series_title, t.program_title, t.episode_title, t.unit_type, t.production_date, t.availability_date, t.length, t.closed_caption, t.stereo, t.dolby, t.colorbw, t.sap3, t.sap4, t.flagged1, t.flagged2, t.open_dbs_flag, t.arrival_date_pds, t.master_format, t.master_comment, t.program_group, t.isbn_, t.distributors_code_curr, t.distributor_name, t.contact_name, t.address_1, t.address_2, t.address_3, t.city, t.state, t.zip, t.phone, t.extension, t.alternate_phone, t.alternate_extension, t.fax, t.original_distributor, t.shipped_from_code, t.author, t.publisher, t.edition, t.opid_last_updated, t.date_last_updated });

            // Properties
            this.Property(t => t.unit_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.program_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.episode_title)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.unit_type)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.closed_caption)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.stereo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.dolby)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.colorbw)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.sap4)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flagged1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flagged2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.open_dbs_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.master_format)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.master_comment)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.program_group)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.isbn_)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.distributors_code_curr)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.distributor_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.contact_name)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.address_1)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.address_2)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.address_3)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.state)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.zip)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.extension)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.alternate_phone)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.alternate_extension)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.fax)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.original_distributor)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.shipped_from_code)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.author)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.publisher)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.edition)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.opid_last_updated)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("als_edge");
            this.Property(t => t.unit_nola).HasColumnName("unit_nola");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.episode_title).HasColumnName("episode_title");
            this.Property(t => t.unit_type).HasColumnName("unit_type");
            this.Property(t => t.production_date).HasColumnName("production_date");
            this.Property(t => t.availability_date).HasColumnName("availability_date");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.closed_caption).HasColumnName("closed_caption");
            this.Property(t => t.stereo).HasColumnName("stereo");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.colorbw).HasColumnName("colorbw");
            this.Property(t => t.sap3).HasColumnName("sap3");
            this.Property(t => t.sap4).HasColumnName("sap4");
            this.Property(t => t.flagged1).HasColumnName("flagged1");
            this.Property(t => t.flagged2).HasColumnName("flagged2");
            this.Property(t => t.open_dbs_flag).HasColumnName("open_dbs_flag");
            this.Property(t => t.arrival_date_pds).HasColumnName("arrival_date_pds");
            this.Property(t => t.master_format).HasColumnName("master_format");
            this.Property(t => t.master_comment).HasColumnName("master_comment");
            this.Property(t => t.program_group).HasColumnName("program_group");
            this.Property(t => t.isbn_).HasColumnName("isbn#");
            this.Property(t => t.distributors_code_curr).HasColumnName("distributors_code_curr");
            this.Property(t => t.distributor_name).HasColumnName("distributor_name");
            this.Property(t => t.contact_name).HasColumnName("contact_name");
            this.Property(t => t.address_1).HasColumnName("address_1");
            this.Property(t => t.address_2).HasColumnName("address_2");
            this.Property(t => t.address_3).HasColumnName("address_3");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.extension).HasColumnName("extension");
            this.Property(t => t.alternate_phone).HasColumnName("alternate_phone");
            this.Property(t => t.alternate_extension).HasColumnName("alternate_extension");
            this.Property(t => t.fax).HasColumnName("fax");
            this.Property(t => t.original_distributor).HasColumnName("original_distributor");
            this.Property(t => t.shipped_from_code).HasColumnName("shipped_from_code");
            this.Property(t => t.author).HasColumnName("author");
            this.Property(t => t.publisher).HasColumnName("publisher");
            this.Property(t => t.edition).HasColumnName("edition");
            this.Property(t => t.opid_last_updated).HasColumnName("opid_last_updated");
            this.Property(t => t.date_last_updated).HasColumnName("date_last_updated");
        }
    }
}
