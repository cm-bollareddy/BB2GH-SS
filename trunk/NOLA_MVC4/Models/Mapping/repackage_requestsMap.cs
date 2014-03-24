using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class repackage_requestsMap : EntityTypeConfiguration<repackage_requests>
    {
        public repackage_requestsMap()
        {
            // Primary Key
            this.HasKey(t => t.request_number);

            // Properties
            this.Property(t => t.request_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nola_code)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.title)
                .HasMaxLength(40);

            this.Property(t => t.episode_title)
                .HasMaxLength(40);

            this.Property(t => t.requested_by)
                .HasMaxLength(40);

            this.Property(t => t.request_type)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.closed_capt)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.current_subscript)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.new_subscript)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.specific_changes)
                .HasMaxLength(490);

            this.Property(t => t.prod_instr_supplied)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prgm_supervision)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.who_supervise)
                .HasMaxLength(25);

            this.Property(t => t.screen_cass_req)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.prod_supplied_spot_reel)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.recipient)
                .HasMaxLength(25);

            this.Property(t => t.replace_tapes)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.master)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.backup)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.cc_reformatting_req)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.disposition)
                .HasMaxLength(70);

            this.Property(t => t.billing_info)
                .HasMaxLength(200);

            this.Property(t => t.comments)
                .HasMaxLength(180);

            // Table & Column Mappings
            this.ToTable("repackage_requests");
            this.Property(t => t.request_number).HasColumnName("request_number");
            this.Property(t => t.nola_code).HasColumnName("nola_code");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.episode_title).HasColumnName("episode_title");
            this.Property(t => t.original_ttime).HasColumnName("original_ttime");
            this.Property(t => t.requested_by).HasColumnName("requested_by");
            this.Property(t => t.date_requested).HasColumnName("date_requested");
            this.Property(t => t.request_type).HasColumnName("request_type");
            this.Property(t => t.prefeed_date).HasColumnName("prefeed_date");
            this.Property(t => t.hardfeed_date).HasColumnName("hardfeed_date");
            this.Property(t => t.closed_capt).HasColumnName("closed_capt");
            this.Property(t => t.current_subscript).HasColumnName("current_subscript");
            this.Property(t => t.new_subscript).HasColumnName("new_subscript");
            this.Property(t => t.specific_changes).HasColumnName("specific_changes");
            this.Property(t => t.completed_by).HasColumnName("completed_by");
            this.Property(t => t.prod_instr_supplied).HasColumnName("prod_instr_supplied");
            this.Property(t => t.prgm_supervision).HasColumnName("prgm_supervision");
            this.Property(t => t.who_supervise).HasColumnName("who_supervise");
            this.Property(t => t.screen_cass_req).HasColumnName("screen_cass_req");
            this.Property(t => t.date_screen_req).HasColumnName("date_screen_req");
            this.Property(t => t.prod_supplied_spot_reel).HasColumnName("prod_supplied_spot_reel");
            this.Property(t => t.spot_arrival_date).HasColumnName("spot_arrival_date");
            this.Property(t => t.recipient).HasColumnName("recipient");
            this.Property(t => t.replace_tapes).HasColumnName("replace_tapes");
            this.Property(t => t.replace_arrv_date).HasColumnName("replace_arrv_date");
            this.Property(t => t.master).HasColumnName("master");
            this.Property(t => t.backup).HasColumnName("backup");
            this.Property(t => t.cc_reformatting_req).HasColumnName("cc_reformatting_req");
            this.Property(t => t.disposition).HasColumnName("disposition");
            this.Property(t => t.billing_info).HasColumnName("billing_info");
            this.Property(t => t.comments).HasColumnName("comments");
        }
    }
}
