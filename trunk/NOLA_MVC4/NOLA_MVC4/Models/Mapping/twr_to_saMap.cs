using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class twr_to_saMap : EntityTypeConfiguration<twr_to_sa>
    {
        public twr_to_saMap()
        {
            // Primary Key
            this.HasKey(t => t.twr_number);

            // Properties
            this.Property(t => t.twr_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(t => t.subscript)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.instructions)
                .IsRequired()
                .HasMaxLength(360);

            this.Property(t => t.subscript_definition)
                .IsRequired()
                .HasMaxLength(45);

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

            this.Property(t => t.remarks)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("twr_to_sa");
            this.Property(t => t.twr_number).HasColumnName("twr_number");
            this.Property(t => t.job_number).HasColumnName("job_number");
            this.Property(t => t.subscript).HasColumnName("subscript");
            this.Property(t => t.due_date).HasColumnName("due_date");
            this.Property(t => t.next_air_date).HasColumnName("next_air_date");
            this.Property(t => t.instructions).HasColumnName("instructions");
            this.Property(t => t.date_completed).HasColumnName("date_completed");
            this.Property(t => t.trt).HasColumnName("trt");
            this.Property(t => t.subscript_definition).HasColumnName("subscript_definition");
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
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.xact_time).HasColumnName("xact_time");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
