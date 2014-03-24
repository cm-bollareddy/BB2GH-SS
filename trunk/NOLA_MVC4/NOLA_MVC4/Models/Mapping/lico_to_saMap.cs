using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class lico_to_saMap : EntityTypeConfiguration<lico_to_sa>
    {
        public lico_to_saMap()
        {
            // Primary Key
            this.HasKey(t => new { t.item_no, t.barcode_no, t.shelf_number, t.job_number, t.date_made, t.producer, t.title, t.length, t.stereo_mono, t.notes, t.mformat, t.user1, t.user2, t.user3, t.user4, t.user5, t.date_creat, t.xact_time, t.operation });

            // Properties
            this.Property(t => t.item_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.barcode_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.shelf_number)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.job_number)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.date_made)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.producer)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.title)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.length)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stereo_mono)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.notes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.mformat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.user1)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.user2)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.user3)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.user4)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.user5)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.date_creat)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.xact_time)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.operation)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("lico_to_sa");
            this.Property(t => t.item_no).HasColumnName("item_no");
            this.Property(t => t.barcode_no).HasColumnName("barcode_no");
            this.Property(t => t.shelf_number).HasColumnName("shelf_number");
            this.Property(t => t.job_number).HasColumnName("job_number");
            this.Property(t => t.date_made).HasColumnName("date_made");
            this.Property(t => t.producer).HasColumnName("producer");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.stereo_mono).HasColumnName("stereo_mono");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.mformat).HasColumnName("mformat");
            this.Property(t => t.user1).HasColumnName("user1");
            this.Property(t => t.user2).HasColumnName("user2");
            this.Property(t => t.user3).HasColumnName("user3");
            this.Property(t => t.user4).HasColumnName("user4");
            this.Property(t => t.user5).HasColumnName("user5");
            this.Property(t => t.date_creat).HasColumnName("date_creat");
            this.Property(t => t.xact_time).HasColumnName("xact_time");
            this.Property(t => t.operation).HasColumnName("operation");
        }
    }
}
