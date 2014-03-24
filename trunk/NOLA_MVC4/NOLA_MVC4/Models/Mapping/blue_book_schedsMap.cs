using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class blue_book_schedsMap : EntityTypeConfiguration<blue_book_scheds>
    {
        public blue_book_schedsMap()
        {
            // Primary Key
            this.HasKey(t => t.bb_sched_id);

            // Properties
            this.Property(t => t.bb_sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("blue_book_scheds");
            this.Property(t => t.bb_sched_id).HasColumnName("bb_sched_id");
        }
    }
}
