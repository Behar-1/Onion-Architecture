using OA.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.SERVICE
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        void AddUser(User user);
        void UpdateUser(User user); 
        void DeleteUser(long id);
    }
}
