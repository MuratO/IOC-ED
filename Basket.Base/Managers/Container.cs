using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase.Managers
{
    public class Container
    {
        private static IWindsorContainer _instance;
        private static IWindsorContainer Instance
        {
            get
            {
                if (_instance == null) _instance = BootContainer();
                return _instance;
            }
        }

        private static IWindsorContainer BootContainer()
        {
            return new WindsorContainer();
        }
        internal static T Resolve<T>()
        {
            return Instance.Resolve<T>();
        }
        internal static void RegisterService(Type baseType, Type service)
        {
            Instance.Register(Component.For(baseType).ImplementedBy(service));
        } 
        internal static void RegisterFromAssembly(Type baseType, Type componentType)
        {
            Instance.Register(
                                Types.FromThisAssembly().BasedOn(baseType).WithService.FirstInterface(),
                                Component.For(componentType).LifestylePerThread());
        }

        internal static void Release(object instance)
        {
            Instance.Release(instance);
        }

        internal static void RegisterFacility(IFacility facility)
        {
            Instance.AddFacility(facility);
        }
    }
}
