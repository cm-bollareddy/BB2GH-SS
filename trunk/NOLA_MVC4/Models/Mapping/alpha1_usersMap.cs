using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alpha1_usersMap : EntityTypeConfiguration<alpha1_users>
    {
        public alpha1_usersMap()
        {
            // Primary Key
            this.HasKey(t => new { t.username, t.owner });

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(17);

            this.Property(t => t.owner)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(21);

            // Table & Column Mappings
            this.ToTable("alpha1_users", "pdbnola");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.owner).HasColumnName("owner");
        }
    }
}
