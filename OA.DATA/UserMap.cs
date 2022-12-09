using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DATA
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder) 
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Email);
            entityBuilder.Property(t => t.Password);
            entityBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
