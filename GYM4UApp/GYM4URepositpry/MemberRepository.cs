using GYM4U.Repository.Common;
using GYM4UDAL;
using System;
using System.Linq;

namespace GYM4U.Repository
{
    public class MemberRepository : IDisposable, IMemberRepository
    {
        // SECURITY_DBEntities it is your context class
        Gym4UEntities context = new Gym4UEntities();

        //This method is used to check and validate the user credentials
        public Member IsActiveUser()
        {
            return context.Member.FirstOrDefault(user =>
          user.IsActive == true);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}