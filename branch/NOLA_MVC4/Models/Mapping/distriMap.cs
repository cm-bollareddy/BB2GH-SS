using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class distriMap : EntityTypeConfiguration<distri>
    {
        public distriMap()
        {
            // Primary Key
            this.HasKey(t => t.di_code);

            // Properties
            this.Property(t => t.di_code)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.di_name)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.di_conname)
                .HasMaxLength(40);

            this.Property(t => t.di_addr1)
                .HasMaxLength(40);

            this.Property(t => t.di_addr2)
                .HasMaxLength(40);

            this.Property(t => t.di_addr3)
                .HasMaxLength(40);

            this.Property(t => t.di_city)
                .HasMaxLength(25);

            this.Property(t => t.di_st)
                .HasMaxLength(2);

            this.Property(t => t.di_zip)
                .HasMaxLength(9);

            this.Property(t => t.di_phone1)
                .HasMaxLength(10);

            this.Property(t => t.di_ext1)
                .HasMaxLength(4);

            this.Property(t => t.di_phone2)
                .HasMaxLength(10);

            this.Property(t => t.di_ext2)
                .HasMaxLength(4);

            this.Property(t => t.di_fax)
                .HasMaxLength(10);

            this.Property(t => t.di_flag)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("distri");
            this.Property(t => t.di_code).HasColumnName("di_code");
            this.Property(t => t.di_name).HasColumnName("di_name");
            this.Property(t => t.di_conname).HasColumnName("di_conname");
            this.Property(t => t.di_addr1).HasColumnName("di_addr1");
            this.Property(t => t.di_addr2).HasColumnName("di_addr2");
            this.Property(t => t.di_addr3).HasColumnName("di_addr3");
            this.Property(t => t.di_city).HasColumnName("di_city");
            this.Property(t => t.di_st).HasColumnName("di_st");
            this.Property(t => t.di_zip).HasColumnName("di_zip");
            this.Property(t => t.di_phone1).HasColumnName("di_phone1");
            this.Property(t => t.di_ext1).HasColumnName("di_ext1");
            this.Property(t => t.di_phone2).HasColumnName("di_phone2");
            this.Property(t => t.di_ext2).HasColumnName("di_ext2");
            this.Property(t => t.di_fax).HasColumnName("di_fax");
            this.Property(t => t.di_flag).HasColumnName("di_flag");
        }
    }
}
