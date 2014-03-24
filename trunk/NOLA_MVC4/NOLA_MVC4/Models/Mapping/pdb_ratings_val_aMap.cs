using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class pdb_ratings_val_aMap : EntityTypeConfiguration<pdb_ratings_val_a>
    {
        public pdb_ratings_val_aMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rating, t.rating_desc, t.subrating, t.subrating_desc, t.database_no, t.transaction_id, t.sequence_no });

            // Properties
            this.Property(t => t.rating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.rating_desc)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.subrating)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.subrating_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.database_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.transaction_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sequence_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("pdb_ratings_val_a");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.rating_desc).HasColumnName("rating_desc");
            this.Property(t => t.subrating).HasColumnName("subrating");
            this.Property(t => t.subrating_desc).HasColumnName("subrating_desc");
            this.Property(t => t.database_no).HasColumnName("database_no");
            this.Property(t => t.transaction_id).HasColumnName("transaction_id");
            this.Property(t => t.sequence_no).HasColumnName("sequence_no");
        }
    }
}
