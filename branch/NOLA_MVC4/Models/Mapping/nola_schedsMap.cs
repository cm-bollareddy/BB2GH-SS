using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_schedsMap : EntityTypeConfiguration<nola_scheds>
    {
        public nola_schedsMap()
        {
            // Primary Key
            this.HasKey(t => t.sched_id);

            // Properties
            this.Property(t => t.sched_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("nola_scheds", "pdbnola");
            this.Property(t => t.sched_id).HasColumnName("sched_id");
        }
    }
}
