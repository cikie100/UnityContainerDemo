using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using UnityContainerDemo.Interfaces;

namespace UnityContainerDemo
{
    public class Driver
    {
        private ICar _car = null;
        private string _name = string.Empty;
        //private ICarKey _key = null;

        public Driver(ICar car )
        {
            _car = car;
        }


        //public Driver(ICar car, ICarKey key) {
        //    _car = car;
        //    _key = key;
        //}


        //Meerdere constructors
        //[InjectionConstructor] 
        //public Driver(ICar car) { _car = car; }
        //public Driver(string name) { }

        //Primitieve parameter
        public Driver(ICar car, string driverName)
        {
            _car = car;
            _name = driverName;
        }

        //public void RunCar() {
        //    Console.WriteLine("Running {0} with {1} - {2} mile ", 
        //        _car.GetType().Name, 
        //        _key.GetType().Name, 
        //        _car.Run());
        //}

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ",
                _car.GetType().Name, _car.Run());

            //Console.WriteLine("{0} is running {1} - {2} mile ",
            //    _name, _car.GetType().Name, _car.Run());


        }
    }
}
