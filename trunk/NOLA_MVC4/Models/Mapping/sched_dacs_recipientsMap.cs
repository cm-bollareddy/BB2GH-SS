using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sched_dacs_recipientsMap : EntityTypeConfiguration<sched_dacs_recipients>
    {
        public sched_dacs_recipientsMap()
        {
            // Primary Key
            this.HasKey(t => t.call_letters);

            // Properties
            this.Property(t => t.call_letters)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.dacs_recipient)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("sched_dacs_recipients");
            this.Property(t => t.call_letters).HasColumnName("call_letters");
            this.Property(t => t.dacs_recipient).HasColumnName("dacs_recipient");
        }
    }
}
