using ClinicManagmentAPI.Models.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI.Models.EnitiesTypeConfiguraaions
{
    public class ProcedureTitleEntityConfiguration : IEntityTypeConfiguration<ProcedureTitle>
    {
        public void Configure(EntityTypeBuilder<ProcedureTitle> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatorUser).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.ModifiedUser).IsRequired(false);
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            //entity configuration
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
