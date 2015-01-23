using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class bosch_user_valMap : EntityTypeConfiguration<bosch_user_val>
    {
        public bosch_user_valMap()
        {
            // Primary Key
            this.HasKey(t => t.username);

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.last_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.first_name_mi)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("bosch_user_val");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.last_name).HasColumnName("last_name");
            this.Property(t => t.first_name_mi).HasColumnName("first_name_mi");
        }
    }
}
