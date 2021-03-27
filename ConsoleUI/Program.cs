using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { DescriptionOfCar = "Volvo V40", DailyPrice = 280, ModelYear = 2018, BrandId=1, ColorId=1 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DescriptionOfCar);
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " + car.DescriptionOfCar);
            //}
            //Console.WriteLine("------------------------------------------");

            //var result = carManager.GetById(1);
            //Console.WriteLine(result.DescriptionOfCar);


            ////carManager.Add(new Car {Id=10, BrandId=1, ColorId=1, DailyPrice=900, ModelYear=2021, Description="2.5 Dizel 4x4" });

            ////carManager.Delete(new Car { Id = 3 });

            //carManager.Update(new Car { CarId = 5, BrandId = 1, ColorId = 1, DailyPrice = 900, ModelYear = 2021, DescriptionOfCar = "2.5 Dizel 4x4" });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + " " + car.DescriptionOfCar);
            //}



        }
    }
}
