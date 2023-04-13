using Autofac;
using Autofac.Integration.Mvc;
using GYM4U.Repository;
using GYM4U.Repository.Common;
using GYM4U.Service;
using GYM4U.Service.Common;
using GYM4UDAL;
using GYM4URepository.Common;
using GYM4URepositpry;
using GYM4UService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace GYM4UApp.App_Start
{
    public class DICONGIF
    {
        public static void Configuration()
        {

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<MemberService>().As<IMemberService>();
            builder.RegisterType<MembershipCardService>().As<IMembershipCardService>();
            builder.RegisterType<MembershipTypeService>().As<IMembershipTypeService>();
            builder.RegisterType<RoleService>().As<IRoleService>();
            builder.RegisterType<AppUserService>().As<IAppUserService>();
            builder.RegisterType<ActivityService>().As<IActivityService>();

            builder.RegisterType<MemberRepository>().As<IMemberRepository>();
            builder.RegisterType<MembershipTypeRepository>().As<IMembershipTypeRepository>();
            builder.RegisterType<MembershipCardRepository>().As<IMembershipCardRepository>();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>();
            builder.RegisterType<AppUserRepository>().As<IAppUserRepository>();
            builder.RegisterType<ActivityRepository>().As<IActivityRepository>();


            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}