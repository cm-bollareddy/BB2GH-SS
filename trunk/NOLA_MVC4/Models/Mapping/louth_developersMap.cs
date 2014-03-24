using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class louth_developersMap : EntityTypeConfiguration<louth_developers>
    {
        public louth_developersMap()
        {
            // Primary Key
            this.HasKey(t => t.developer_username);

            // Properties
            this.Property(t => t.developer_username)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("louth_developers");
            this.Property(t => t.developer_username).HasColumnName("developer_username");
        }
    }
}
