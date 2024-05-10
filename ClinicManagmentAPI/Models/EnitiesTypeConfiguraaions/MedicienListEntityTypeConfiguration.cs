using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class MedicienListEntityTypeConfiguration : IEntityTypeConfiguration<MedicienList>
    {
        public void Configure(EntityTypeBuilder<MedicienList> builder)
        {
            //Required Entity
            builder.ToTable("MedicienList");
            builder.ToTable(x => x.HasCheckConstraint("CH_MedicienList_QTN", "QTN >= 1"));
            builder.ToTable(x => x.HasCheckConstraint("CH_MedicienList_Dose", "Dose >= 3"));
            builder.ToTable(x => x.HasCheckConstraint("CH_MedicienList_PerHour", "PerHour >= 8"));
            builder.Property(x => x.QTN).IsRequired();
            builder.Property(x => x.Dose).IsRequired();
            builder.Property(x => x.PerHour).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.MedicienId).IsRequired();
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
        }
    }
}
