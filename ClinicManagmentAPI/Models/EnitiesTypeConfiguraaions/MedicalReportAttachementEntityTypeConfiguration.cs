using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class MedicalReportAttachementEntityTypeConfiguration : IEntityTypeConfiguration<MedicalReportAttachement>
    {
        public void Configure(EntityTypeBuilder<MedicalReportAttachement> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            
            
            
            
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
