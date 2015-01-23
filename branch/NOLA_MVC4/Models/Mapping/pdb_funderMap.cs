using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_funderMap : EntityTypeConfiguration<pdb_funder>
    {
        public pdb_funderMap()
        {
            // Primary Key
            this.HasKey(t => t.code);

            // Properties
            this.Property(t => t.code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.parent)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.@class)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.addr1)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.addr2)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.city)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.state)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.sales)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.officer)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.contact_1)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.contact_2)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ad_agency)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pr_agency)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.comment)
                .IsRequired()
                .HasMaxLength(74);

            // Table & Column Mappings
            this.ToTable("pdb_funder");
            this.Property(t => t.code).HasColumnName("code");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.parent).HasColumnName("parent");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.@class).HasColumnName("class");
            this.Property(t => t.addr1).HasColumnName("addr1");
            this.Property(t => t.addr2).HasColumnName("addr2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.sales).HasColumnName("sales");
            this.Property(t => t.employees).HasColumnName("employees");
            this.Property(t => t.ad_budget).HasColumnName("ad_budget");
            this.Property(t => t.officer).HasColumnName("officer");
            this.Property(t => t.contact_1).HasColumnName("contact_1");
            this.Property(t => t.contact_2).HasColumnName("contact_2");
            this.Property(t => t.ad_agency).HasColumnName("ad_agency");
            this.Property(t => t.pr_agency).HasColumnName("pr_agency");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
