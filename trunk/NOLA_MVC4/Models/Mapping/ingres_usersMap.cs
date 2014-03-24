using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class ingres_usersMap : EntityTypeConfiguration<ingres_users>
    {
        public ingres_usersMap()
        {
            // Primary Key
            this.HasKey(t => t.name);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ingres_users");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.default_priv).HasColumnName("default_priv");
            this.Property(t => t.expire_date).HasColumnName("expire_date");
        }
    }
}
