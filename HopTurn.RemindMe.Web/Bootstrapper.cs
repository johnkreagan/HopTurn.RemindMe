using HopTurn.RemindMe.Web.App;
using HopTurn.RemindMe.Web.Controllers;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HopTurn.RemindMe.Web
{
    public static class Bootstrapper
    {

        public static void Init()
        {

            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new Microsoft.Practices.Unity.Mvc.UnityDependencyResolver(container));

            IDependencyResolver resolver = DependencyResolver.Current;

            IDependencyResolver newResolver = new Factories.UnityDependencyResolver(container, resolver);

            DependencyResolver.SetResolver(newResolver);
            
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IReminderEngine, ReminderEngine>();
            //container.RegisterInstance<IReminderEngine>(new ReminderEngine());

            //DependencyContainer.SetResolver(container);
            //container.Resolve<ReminderController>();
            return container;
        }


    }
}