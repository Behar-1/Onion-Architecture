using OA.DATA;
using OA.REPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.SERVICE
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }


        public UserProfile GetUserProfile(long id)
        {
            return this.userProfileRepository.Get(id);
        }
    }
}
