using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_not_recordMap : EntityTypeConfiguration<louth_not_record>
    {
        public louth_not_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.current_distributor);

            // Properties
            this.Property(t => t.current_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("louth_not_record");
            this.Property(t => t.current_distributor).HasColumnName("current_distributor");
        }
    }
}
