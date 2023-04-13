using GYM4U.Repository.Common;
using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM4U.Service
{
    public class RoleService : IRoleService
    {
        protected IRoleRepository Repository { get; set; }

        public RoleService(IRoleRepository repository)
        {
            Repository = repository;
        }
    }
}
