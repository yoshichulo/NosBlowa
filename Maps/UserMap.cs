using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NosBlowa.Models;

namespace NosBlowa.Maps
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("user");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Id).HasColumnName("username");
            entityBuilder.Property(x => x.Id).HasColumnName("password");
        }
    }
}