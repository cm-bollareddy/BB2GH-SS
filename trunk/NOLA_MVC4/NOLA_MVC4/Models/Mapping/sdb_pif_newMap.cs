using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NOLA_MVC4.Models.Mapping
{
    public class sdb_pif_newMap : EntityTypeConfiguration<sdb_pif_new>
    {
        public sdb_pif_newMap()
        {
            // Primary Key
            this.HasKey(t => t.dea_id);

            // Properties
            this.Property(t => t.dea_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.previously_broadcast)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.previous_distributor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.pbs_acceptor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(26);

            this.Property(t => t.pif_wti)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pif_wti1_text)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pbs_prog_mgmt_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_prog_mgmt_phone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.pbs_prog_mgmt_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_editorial_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_editorial_email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pbs_editorial_phone)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.embedded_data)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.promo_materials_online)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.promo_materials_online_desc)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.webmarkers_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.website_flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.contact_organization_req)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.contact_address_req)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.pd_contact_organization_req)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.pd_contact_address_req)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.cp_contact_organization_req)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.cp_contact_address_req)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.content_alert_language)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_alert_material)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.content_alert_language_desc)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.content_alert_material_desc)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("sdb_pif_new");
            this.Property(t => t.dea_id).HasColumnName("dea_id");
            this.Property(t => t.previously_broadcast).HasColumnName("previously_broadcast");
            this.Property(t => t.previous_distributor).HasColumnName("previous_distributor");
            this.Property(t => t.pbs_acceptor).HasColumnName("pbs_acceptor");
            this.Property(t => t.pif_wti).HasColumnName("pif_wti");
            this.Property(t => t.pif_wti1_text).HasColumnName("pif_wti1_text");
            this.Property(t => t.pbs_prog_mgmt_name).HasColumnName("pbs_prog_mgmt_name");
            this.Property(t => t.pbs_prog_mgmt_phone).HasColumnName("pbs_prog_mgmt_phone");
            this.Property(t => t.pbs_prog_mgmt_email).HasColumnName("pbs_prog_mgmt_email");
            this.Property(t => t.pbs_editorial_name).HasColumnName("pbs_editorial_name");
            this.Property(t => t.pbs_editorial_email).HasColumnName("pbs_editorial_email");
            this.Property(t => t.pbs_editorial_phone).HasColumnName("pbs_editorial_phone");
            this.Property(t => t.embedded_data).HasColumnName("embedded_data");
            this.Property(t => t.promo_materials_online).HasColumnName("promo_materials_online");
            this.Property(t => t.promo_materials_online_desc).HasColumnName("promo_materials_online_desc");
            this.Property(t => t.webmarkers_flag).HasColumnName("webmarkers_flag");
            this.Property(t => t.website_flag).HasColumnName("website_flag");
            this.Property(t => t.contact_organization_req).HasColumnName("contact_organization_req");
            this.Property(t => t.contact_address_req).HasColumnName("contact_address_req");
            this.Property(t => t.contact_type_req).HasColumnName("contact_type_req");
            this.Property(t => t.pd_contact_organization_req).HasColumnName("pd_contact_organization_req");
            this.Property(t => t.pd_contact_address_req).HasColumnName("pd_contact_address_req");
            this.Property(t => t.pd_contact_type_req).HasColumnName("pd_contact_type_req");
            this.Property(t => t.cp_contact_organization_req).HasColumnName("cp_contact_organization_req");
            this.Property(t => t.cp_contact_address_req).HasColumnName("cp_contact_address_req");
            this.Property(t => t.cp_contact_type_req).HasColumnName("cp_contact_type_req");
            this.Property(t => t.content_alert_language).HasColumnName("content_alert_language");
            this.Property(t => t.content_alert_material).HasColumnName("content_alert_material");
            this.Property(t => t.content_alert_language_desc).HasColumnName("content_alert_language_desc");
            this.Property(t => t.content_alert_material_desc).HasColumnName("content_alert_material_desc");
        }
    }
}
