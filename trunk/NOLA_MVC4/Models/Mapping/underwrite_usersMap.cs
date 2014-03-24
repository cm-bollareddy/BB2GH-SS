using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class underwrite_usersMap : EntityTypeConfiguration<underwrite_users>
    {
        public underwrite_usersMap()
        {
            // Primary Key
            this.HasKey(t => t.username);

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("underwrite_users");
            this.Property(t => t.username).HasColumnName("username");
        }
    }
}
