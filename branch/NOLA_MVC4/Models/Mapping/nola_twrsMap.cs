using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_twrsMap : EntityTypeConfiguration<nola_twrs>
    {
        public nola_twrsMap()
        {
            // Primary Key
            this.HasKey(t => t.twr_number);

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.twr_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.master_clone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.caption_file_name_1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.caption_file_name_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.caption_file_name_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.entered_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.series_nola)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.nola_display)
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

            this.Property(t => t.instruction_code)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.instructions)
                .IsRequired()
                .HasMaxLength(360);

            this.Property(t => t.technician_remarks)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.scheduler_remarks)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.completed_by)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.bill_rate_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.bill_customer_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.bill_station)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.bill_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.bill_organization)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.bill_address_1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.bill_address_2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.bill_city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.bill_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.bill_zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.bill_zip_plus_four)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.bill_phone_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.bill_phone_exchange)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.bill_phone_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.disp_station)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.disp_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.disp_organization)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.disp_address_1)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.disp_address_2)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.disp_city)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.disp_state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.disp_zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.disp_zip_plus_four)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.disp_phone_area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.disp_phone_exchange)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.disp_phone_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.disp_library_notes)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.printed)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.invoice_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("nola_twrs");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.twr_master).HasColumnName("twr_master");
            this.Property(t => t.twr_type).HasColumnName("twr_type");
            this.Property(t => t.master_clone).HasColumnName("master_clone");
            this.Property(t => t.caption_file_name_1).HasColumnName("caption_file_name_1");
            this.Property(t => t.caption_file_name_2).HasColumnName("caption_file_name_2");
            this.Property(t => t.caption_file_name_3).HasColumnName("caption_file_name_3");
            this.Property(t => t.date_required).HasColumnName("date_required");
            this.Property(t => t.time_required).HasColumnName("time_required");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.entered_by).HasColumnName("entered_by");
            this.Property(t => t.date_entered).HasColumnName("date_entered");
            this.Property(t => t.series_nola).HasColumnName("series_nola");
            this.Property(t => t.nola_display).HasColumnName("nola_display");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.series_title).HasColumnName("series_title");
            this.Property(t => t.series_title_soundex).HasColumnName("series_title_soundex");
            this.Property(t => t.program_title).HasColumnName("program_title");
            this.Property(t => t.program_title_soundex).HasColumnName("program_title_soundex");
            this.Property(t => t.instruction_code).HasColumnName("instruction_code");
            this.Property(t => t.instructions).HasColumnName("instructions");
            this.Property(t => t.technician_remarks).HasColumnName("technician_remarks");
            this.Property(t => t.scheduler_remarks).HasColumnName("scheduler_remarks");
            this.Property(t => t.completed_by).HasColumnName("completed_by");
            this.Property(t => t.date_time_completed).HasColumnName("date_time_completed");
            this.Property(t => t.blanket_amount).HasColumnName("blanket_amount");
            this.Property(t => t.bill_rate_type).HasColumnName("bill_rate_type");
            this.Property(t => t.bill_cost_center).HasColumnName("bill_cost_center");
            this.Property(t => t.bill_customer_code).HasColumnName("bill_customer_code");
            this.Property(t => t.bill_billing_amount).HasColumnName("bill_billing_amount");
            this.Property(t => t.bill_station).HasColumnName("bill_station");
            this.Property(t => t.bill_name).HasColumnName("bill_name");
            this.Property(t => t.bill_organization).HasColumnName("bill_organization");
            this.Property(t => t.bill_address_1).HasColumnName("bill_address_1");
            this.Property(t => t.bill_address_2).HasColumnName("bill_address_2");
            this.Property(t => t.bill_city).HasColumnName("bill_city");
            this.Property(t => t.bill_state).HasColumnName("bill_state");
            this.Property(t => t.bill_zip).HasColumnName("bill_zip");
            this.Property(t => t.bill_zip_plus_four).HasColumnName("bill_zip_plus_four");
            this.Property(t => t.bill_phone_area).HasColumnName("bill_phone_area");
            this.Property(t => t.bill_phone_exchange).HasColumnName("bill_phone_exchange");
            this.Property(t => t.bill_phone_number).HasColumnName("bill_phone_number");
            this.Property(t => t.disp_station).HasColumnName("disp_station");
            this.Property(t => t.disp_name).HasColumnName("disp_name");
            this.Property(t => t.disp_organization).HasColumnName("disp_organization");
            this.Property(t => t.disp_address_1).HasColumnName("disp_address_1");
            this.Property(t => t.disp_address_2).HasColumnName("disp_address_2");
            this.Property(t => t.disp_city).HasColumnName("disp_city");
            this.Property(t => t.disp_state).HasColumnName("disp_state");
            this.Property(t => t.disp_zip).HasColumnName("disp_zip");
            this.Property(t => t.disp_zip_plus_four).HasColumnName("disp_zip_plus_four");
            this.Property(t => t.disp_phone_area).HasColumnName("disp_phone_area");
            this.Property(t => t.disp_phone_exchange).HasColumnName("disp_phone_exchange");
            this.Property(t => t.disp_phone_number).HasColumnName("disp_phone_number");
            this.Property(t => t.disp_library_notes).HasColumnName("disp_library_notes");
            this.Property(t => t.printed).HasColumnName("printed");
            this.Property(t => t.invoice_date).HasColumnName("invoice_date");
            this.Property(t => t.invoice_number).HasColumnName("invoice_number");
        }
    }
}
