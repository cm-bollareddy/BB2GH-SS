using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class nola_user_roles_bckMap : EntityTypeConfiguration<nola_user_roles_bck>
    {
        public nola_user_roles_bckMap()
        {
            // Primary Key
            this.HasKey(t => new { t.username, t.app });

            // Properties
            this.Property(t => t.username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(32);

            this.Property(t => t.app)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.role_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.first_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.last_name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("nola_user_roles_bck");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.app).HasColumnName("app");
            this.Property(t => t.role_id).HasColumnName("role_id");
            this.Property(t => t.first_name).HasColumnName("first_name");
            this.Property(t => t.last_name).HasColumnName("last_name");
        }
    }
}
