using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class rd_std_commentsMap : EntityTypeConfiguration<rd_std_comments>
    {
        public rd_std_commentsMap()
        {
            // Primary Key
            this.HasKey(t => t.comment_code);

            // Properties
            this.Property(t => t.comment_code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.std_comment)
                .IsRequired()
                .HasMaxLength(360);

            // Table & Column Mappings
            this.ToTable("rd_std_comments");
            this.Property(t => t.comment_code).HasColumnName("comment_code");
            this.Property(t => t.std_comment).HasColumnName("std_comment");
        }
    }
}
