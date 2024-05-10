using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.CreatorUser).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.ModifiedUser).IsRequired(false);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.NationalId).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.IsHaveDiseases).IsRequired();
            builder.Property(x => x.DiesesType).IsRequired(false);
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.ProfileImage).IsRequired(false);
            builder.Property(x => x.Appointments).IsRequired(false);
            builder.Property(x => x.Specialization).IsRequired(false);
            builder.Property(x => x.MedicalReports).IsRequired();
            builder.Property(x => x.MedicalStatus).IsRequired();
        }
    }
}
