using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class Bruce_TestMap : EntityTypeConfiguration<Bruce_Test>
    {
        public Bruce_TestMap()
        {
            // Primary Key
            this.HasKey(t => t.column1);

            // Properties
            this.Property(t => t.column1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.column2)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.column3)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Bruce_Test");
            this.Property(t => t.column1).HasColumnName("column1");
            this.Property(t => t.column2).HasColumnName("column2");
            this.Property(t => t.column3).HasColumnName("column3");
        }
    }
}
