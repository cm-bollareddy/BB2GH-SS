using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class alpha1_wuzzy_usersMap : EntityTypeConfiguration<alpha1_wuzzy_users>
    {
        public alpha1_wuzzy_usersMap()
        {
            // Primary Key
            this.HasKey(t => t.username);

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(17);

            // Table & Column Mappings
            this.ToTable("alpha1_wuzzy_users", "pdbnola");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
