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

            // CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //UserManager userManager = new UserManager(new EfUserDal());
            //User user1 = new User() { UserName="Engin", LastName="Demirog", Email="engindemirog@gmail.com", Password="112233" };
            //userManager.Delete(user1);
            //Customer customer2 = new Customer() { UserId = 3, CompanyName = "Kodlama.io" };
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(customer2);

            //var aciklama = carManager.GetCarById(5).DescriptionOfCar;
            //Console.WriteLine(aciklama);

            //Rental rental1 = new Rental();
            //rental1.CarId = 3;
            //rental1.CustomerId = 1;
            //rental1.RentDate = new DateTime(2021, 5, 13);
            //rental1.ReturnDate = new DateTime(2021, 5, 17);

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            RentalManager rentalManager2 = new RentalManager(new EfRentalDal());

            //rentalManager.Add(rental1);

            Rental rental2 = new Rental();
            rental2.CarId = 4;
            rental2.CustomerId = 3;
            rental2.RentDate = new DateTime(2021, 5, 23);
            rental2.ReturnDate = new DateTime(2021, 5, 25);
            rentalManager2.Add(rental2);



        }
    }
}
