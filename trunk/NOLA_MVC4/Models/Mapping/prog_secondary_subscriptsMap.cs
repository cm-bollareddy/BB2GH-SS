using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class prog_secondary_subscriptsMap : EntityTypeConfiguration<prog_secondary_subscripts>
    {
        public prog_secondary_subscriptsMap()
        {
            // Primary Key
            this.HasKey(t => t.primary_subscript);

            // Properties
            this.Property(t => t.primary_subscript)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.secondary_subscript)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.uncaptioned_pair_ind)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("prog_secondary_subscripts");
            this.Property(t => t.primary_subscript).HasColumnName("primary_subscript");
            this.Property(t => t.secondary_subscript).HasColumnName("secondary_subscript");
            this.Property(t => t.uncaptioned_pair_ind).HasColumnName("uncaptioned_pair_ind");
        }
    }
}
