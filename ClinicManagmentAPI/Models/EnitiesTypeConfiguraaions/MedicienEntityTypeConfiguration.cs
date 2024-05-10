using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class MedicienEntityTypeConfiguration : IEntityTypeConfiguration<Medicien>
    {
        public void Configure(EntityTypeBuilder<Medicien> builder)
        {
            //Required Entity
            builder.ToTable("Medicien");
            builder.ToTable(x => x.HasCheckConstraint("CH_Medicien_Name", "LEN(Name) >= 6"));
            builder.ToTable(x => x.HasCheckConstraint("CH_Medicien_Description", "LEN(Description) >= 8"));
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
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
