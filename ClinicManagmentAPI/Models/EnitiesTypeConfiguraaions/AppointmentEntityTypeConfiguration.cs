using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class AppointmentEntityTypeConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            //Entity Config
            builder.Property(x => x.Description).IsRequired(false);
            builder.ToTable(t => t.HasCheckConstraint("CH_Appointment_Date", "Date >= GetDate()"));
        }
    }
}
