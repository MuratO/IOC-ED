using BasketBase.Managers;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketBase.Interfaces;
using Castle.Windsor.Installer;
using System.Reflection;
using System.Threading;
using Castle.MicroKernel.Registration;
using BasketBase.Consumers;
using BasketBase.Events;
using System.Diagnostics;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel; 

namespace BasketBase
{
  public class Core
    {
        static Core _instance;
        static object _locker = new object();
        public static Core Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                lock (_locker)
                {

                    if (_instance == null)
                    {
                        _instance = new Core();
                    }

                    return _instance;
                }
            }
        }

        private Core(){}
        static Core(){}

        private static ILogger _logger;
        public static ILogger Logger
        {
            get
            {
                if (_logger == null) _logger = Container.Resolve<ILogger>();
                return _logger;
            }
        }

        public static void StartApplication() {
            try
            {
                Container.RegisterService(typeof(ILogger), typeof(ConsoleLogger));
                EventSubscriptions.Register();                 
            }
            catch(Exception ex) {
                Logger.Write(ex.StackTrace);
                StopApplication();
            }

        }
        private static void StopApplication(){}
        
    }
}
