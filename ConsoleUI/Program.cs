﻿using Business.Concrete;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.description);
            }
            
            Console.WriteLine("---------------");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.description);
            }
            Console.WriteLine("---------------");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.description);
            }
        }
    }
}
 