using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class MedicalReportLaborityTestEntityTypeConfiguration : IEntityTypeConfiguration<MedicalReportLaborityTest>
    {
        public void Configure(EntityTypeBuilder<MedicalReportLaborityTest> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.CreationDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatorUser).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.ModifiedUser).IsRequired(false);
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.TestResult).HasMaxLength(255);
            builder.Property(x => x.Servity).IsRequired();
            builder.Property(x => x.TechnicianName).IsRequired();
            builder.Property(x => x.NumberOfTests).IsRequired();
            builder.Property(x => x.SampleType).IsRequired();
        }
    }
}
