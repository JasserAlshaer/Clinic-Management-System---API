using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class MedicalReportEntityTypeConfiguration : IEntityTypeConfiguration<MedicalReport>
    {
        public void Configure(EntityTypeBuilder<MedicalReport> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);

            //Relationships 
            builder.HasMany<MedicalProuducre>().WithOne().HasForeignKey(x => x.MedicalReportId);
            builder.HasMany<MedicalReportLaborityTest>().WithOne().HasForeignKey(x => x.MedicalReportId);
            builder.HasMany<MedicalReportAttachement>().WithOne().HasForeignKey(x => x.MedicalReportId);
            builder.HasMany<MedicienList>().WithOne().HasForeignKey(x => x.MedicalReportId);
            builder.HasMany<SickLeave>().WithOne().HasForeignKey(x => x.MedicalReportId);
            builder.HasMany<Invoice>().WithOne().HasForeignKey(x => x.MedicalReportId);
        }
    }
}
