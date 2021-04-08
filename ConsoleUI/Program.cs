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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());



            //var aciklama = carManager.GetCarById(5).DescriptionOfCar;
            //Console.WriteLine(aciklama);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.ColorName + " " + car.BrandName+ " " + car.CarName + " " + car.DailyPrice);
            }


        }
    }
}
