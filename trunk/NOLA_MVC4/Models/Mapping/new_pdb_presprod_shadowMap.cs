using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class new_pdb_presprod_shadowMap : EntityTypeConfiguration<new_pdb_presprod_shadow>
    {
        public new_pdb_presprod_shadowMap()
        {
            // Primary Key
            this.HasKey(t => t.code);

            // Properties
            this.Property(t => t.code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.address)
                .IsRequired()
                .HasMaxLength(180);

            this.Property(t => t.e_mail)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.country)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.fax)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("new_pdb_presprod_shadow");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.e_mail).HasColumnName("e_mail");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.fax).HasColumnName("fax");
        }
    }
}
