using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }
            Console.WriteLine("------------------------------------------");
            //Console.WriteLine(carManager.GetById(1).Description);

            //carManager.Add(new Car {Id=10, BrandId=1, ColorId=1, DailyPrice=900, ModelYear=2021, Description="2.5 Dizel 4x4" });

            //carManager.Delete(new Car { Id = 3 });

            carManager.Update(new Car{Id = 5, BrandId = 1, ColorId = 1, DailyPrice = 900, ModelYear = 2021, Description = "2.5 Dizel 4x4"});

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }



        }
    }
}
