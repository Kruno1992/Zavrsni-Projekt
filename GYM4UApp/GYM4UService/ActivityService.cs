using GYM4U.Repository.Common;
using GYM4U.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM4UService
{
    public class ActivityService : IActivityService
    {
        protected IActivityRepository Repository { get; set; }

        public ActivityService(IActivityRepository repository)
        {
            Repository = repository;
        }
    }
}
