using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class allocation_archive_24Map : EntityTypeConfiguration<allocation_archive_24>
    {
        public allocation_archive_24Map()
        {
            // Primary Key
            this.HasKey(t => t.alloc_index);

            // Properties
            this.Property(t => t.alloc_index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

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
            this.ToTable("allocation_archive_24");
            this.Property(t => t.alloc_index).HasColumnName("alloc_index");
            this.Property(t => t.sched_index).HasColumnName("sched_index");
            this.Property(t => t.alloc_start).HasColumnName("alloc_start");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
            this.Property(t => t.alloc_end).HasColumnName("alloc_end");
            this.Property(t => t.sched_date).HasColumnName("sched_date");
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
