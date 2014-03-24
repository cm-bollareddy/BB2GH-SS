using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_message_queueMap : EntityTypeConfiguration<sdb_message_queue>
    {
        public sdb_message_queueMap()
        {
            // Primary Key
            this.HasKey(t => t.message_id);

            // Properties
            this.Property(t => t.message_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sender_id)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sender_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.subject)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.is_replyable)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.recipient_list)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.body)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("sdb_message_queue");
            this.Property(t => t.message_id).HasColumnName("message_id");
            this.Property(t => t.sender_id).HasColumnName("sender_id");
            this.Property(t => t.sender_name).HasColumnName("sender_name");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.is_replyable).HasColumnName("is_replyable");
            this.Property(t => t.recipient_list).HasColumnName("recipient_list");
            this.Property(t => t.body).HasColumnName("body");
        }
    }
}
