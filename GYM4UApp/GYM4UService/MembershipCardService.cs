using GYM4U.Repository.Common;
using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM4U.Service
{
    public class MembershipCardService : IMembershipCardService
    {
        protected IMembershipCardRepository Repository { get; set; }

        public MembershipCardService(IMembershipCardRepository repository)
        {
            Repository = repository;
        }
    }
}
