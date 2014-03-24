using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_flag_type_valMap : EntityTypeConfiguration<pdb_flag_type_val>
    {
        public pdb_flag_type_valMap()
        {
            // Primary Key
            this.HasKey(t => t.flag_type);

            // Properties
            this.Property(t => t.flag_type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.flag_type_description)
                .IsRequired()
                .HasMaxLength(26);

            // Table & Column Mappings
            this.ToTable("pdb_flag_type_val");
            this.Property(t => t.flag_type).HasColumnName("flag_type");
            this.Property(t => t.flag_type_description).HasColumnName("flag_type_description");
        }
    }
}
