using OA.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.SERVICE
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);

    }
}
