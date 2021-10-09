using Arepa.BaseData.Context;
using Arepa.DAL.Interfaces;
using Arepa.Share.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arepa.DAL.Repositories
{
    public class AdmSystem : IAdmSystem
    {
        private ArepaContext _oArepaContext;
        public AdmSystem(ArepaContext oArepaContext)
        {
            this._oArepaContext = oArepaContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return this._oArepaContext.Users.ToList();
        }

        public string GetUserName()
        {
            return this._oArepaContext.Users.ToList().FirstOrDefault().UserName;
        }
    }
}
