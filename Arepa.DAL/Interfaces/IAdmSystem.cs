using Arepa.Share.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arepa.DAL.Interfaces
{
    public interface IAdmSystem
    {
        IEnumerable<User> GetUsers();

        string GetUserName();
    }
}
