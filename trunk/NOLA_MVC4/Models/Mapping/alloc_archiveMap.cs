using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alloc_archiveMap : EntityTypeConfiguration<alloc_archive>
    {
        public alloc_archiveMap()
        {
            // Primary Key
            this.HasKey(t => new { t.alloc_index, t.sched_index, t.sched_date, t.sched_id, t.start_time, t.end_time, t.uplink, t.current_distributor, t.nola_root, t.block_desc, t.block_status, t.requested_by, t.received_by, t.billable_flag, t.invoice_date, t.invoice_number });

            // Properties
            this.Property(t => t.alloc_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.start_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.end_time)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.uplink)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.nola_root)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            this.Property(t => t.block_desc)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.block_status)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.requested_by)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.received_by)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.billable_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.invoice_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("alloc_archive");
            this.Property(t => t.alloc_index).HasColumnName("alloc_index");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.start_time).HasColumnName("start_time");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.uplink).HasColumnName("uplink");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
            this.Property(t => t.nola_root).HasColumnName("nola_root");
            this.Property(t => t.block_desc).HasColumnName("block_desc");
            this.Property(t => t.block_status).HasColumnName("block_status");
            this.Property(t => t.requested_by).HasColumnName("requested_by");
            this.Property(t => t.received_by).HasColumnName("received_by");
            this.Property(t => t.billable_flag).HasColumnName("billable_flag");
            this.Property(t => t.invoice_date).HasColumnName("invoice_date");
            this.Property(t => t.invoice_number).HasColumnName("invoice_number");
        }
    }
}
