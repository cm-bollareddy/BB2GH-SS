using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_tiansMap : EntityTypeConfiguration<nola_tians>
    {
        public nola_tiansMap()
        {
            // Primary Key
            this.HasKey(t => t.tian_number);

            // Properties
            this.Property(t => t.tian_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.series_title)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.series_title_soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.program_title)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.program_title_soundex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.tape_size)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.master_backup)
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

            this.Property(t => t.sap)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.air_flag_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.air_flag_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.air_flag_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.air_flag_desc_1)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.air_flag_desc_2)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.air_flag_desc_3)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.tin_technician)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.tian_technician)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.action_taken)
                .IsRequired()
                .HasMaxLength(225);

            this.Property(t => t.time_of_air_action)
                .IsRequired()
                .HasMaxLength(225);

            this.Property(t => t.pres_org)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.presenter_contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.pres_phone_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.pres_phone_exchange)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.pres_phone_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.printed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("nola_tians");
            this.Property(t => t.tian_number).HasColumnName("tian_number");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.control_number).HasColumnName("control_number");
            this.Property(t => t.nola).HasColumnName("nola");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.series_title_soundex).HasColumnName("series_title_soundex");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.program_title_soundex).HasColumnName("program_title_soundex");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.tape_size).HasColumnName("tape_size");
            this.Property(t => t.master_backup).HasColumnName("master_backup");
            this.Property(t => t.stereo).HasColumnName("stereo");
            this.Property(t => t.dolby).HasColumnName("dolby");
            this.Property(t => t.sap).HasColumnName("sap");
            this.Property(t => t.air_date_1).HasColumnName("air_date_1");
            this.Property(t => t.air_date_2).HasColumnName("air_date_2");
            this.Property(t => t.air_date_3).HasColumnName("air_date_3");
            this.Property(t => t.air_flag_1).HasColumnName("air_flag_1");
            this.Property(t => t.air_flag_2).HasColumnName("air_flag_2");
            this.Property(t => t.air_flag_3).HasColumnName("air_flag_3");
            this.Property(t => t.air_flag_desc_1).HasColumnName("air_flag_desc_1");
            this.Property(t => t.air_flag_desc_2).HasColumnName("air_flag_desc_2");
            this.Property(t => t.air_flag_desc_3).HasColumnName("air_flag_desc_3");
            this.Property(t => t.tin_technician).HasColumnName("tin_technician");
            this.Property(t => t.tian_technician).HasColumnName("tian_technician");
            this.Property(t => t.action_taken).HasColumnName("action_taken");
            this.Property(t => t.time_of_air_action).HasColumnName("time_of_air_action");
            this.Property(t => t.pres_org).HasColumnName("pres_org");
            this.Property(t => t.presenter_contact).HasColumnName("presenter_contact");
            this.Property(t => t.pres_phone_area).HasColumnName("pres_phone_area");
            this.Property(t => t.pres_phone_exchange).HasColumnName("pres_phone_exchange");
            this.Property(t => t.pres_phone_number).HasColumnName("pres_phone_number");
            this.Property(t => t.printed).HasColumnName("printed");
        }
    }
}
