using System;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using UnityContainerDemo.Interfaces;
using UnityContainerDemo.Manufacturers;

namespace UnityContainerDemo
{
    public class Program
    {




        static void Main(string[] args)
        {
            //// om IUnityContainer-interface te implementeren
            //IUnityContainer container = new UnityContainer();
            //// de type mapping registreren bij de containe
            //container.RegisterType<ICar, BMW>(); // Register BMW with ICar
            //container.RegisterType<ICar, Audi>("LuxuryCar");

            //// Registers Driver type
            //container.RegisterType<Driver>("LuxuryCarDriver",
            //    //specificeert een constructorinjectie voorde Driver-klasse met een object van klasse Audi
            //    new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            //// Resolves dependencies and returns the Driver object
            //Driver driver1 = container.Resolve<Driver>(); // injects BMW
            //driver1.RunCar();

            //Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            //driver2.RunCar();

            ////
            //var container = new UnityContainer(); 
            //ICar audi = new Audi(); 
            //container.RegisterInstance<ICar>(audi); 

            //Driver driver1 = container.Resolve<Driver>(); 
            //driver1.RunCar(); driver1.RunCar(); 

            //Driver driver2 = container.Resolve<Driver>(); 
            //driver2.RunCar();
            ////

            //var container = new UnityContainer().
            //    RegisterType<ICar, BMW>(); 
            //var driver1 = container.Resolve<Driver>();
            //    driver1.RunCar(); 

            //var driver2 = container.Resolve<Driver>(); 
            //    driver2.RunCar();
            /////////////
            //
            // container.RegisterType<Driver>(new InjectionConstructor(new Ford()));

            //container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" }));
            //var driver = container.Resolve<Driver>(); // Injects Audi and Steve
            //driver.RunCar();

            //
            //newTransientLifetimeManager
            //var container = new UnityContainer().RegisterType<ICar, BMW>(new TransientLifetimeManager());
            //var driver1 = container.Resolve<Driver>(); 
            //driver1.RunCar();

            //var driver2 = container.Resolve<Driver>();
            //driver2.RunCar();

            //
            //newContainerControlledLifetimeManager
            //var container = new UnityContainer().RegisterType<ICar, BMW>(new ContainerControlledLifetimeManager());
            //var driver1 = container.Resolve<Driver>();
            //driver1.RunCar();

            //var driver2 = container.Resolve<Driver>();
            //driver2.RunCar();

            //
            //newHierarchicalLifetimeManager
            var container = new UnityContainer().RegisterType<ICar, BMW>(new HierarchicalLifetimeManager());
            var childContainer = container.CreateChildContainer(); 
            var driver1 = container.Resolve<Driver>(); 
            driver1.RunCar(); 
            
            var driver2 = container.Resolve<Driver>();
            driver2.RunCar(); 
            
            var driver3 = childContainer.Resolve<Driver>(); 
            driver3.RunCar(); 
            
            var driver4 = childContainer.Resolve<Driver>(); 
            driver4.RunCar();
        }
    }
}
