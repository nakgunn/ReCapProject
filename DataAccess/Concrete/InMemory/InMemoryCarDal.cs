using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car{ CarId = 1, BrandId = 1, ColorId = 4, ModelYear = 2018, DailyPrice = 375, DescriptionOfCar = "1.4 Dizel Otomatik" },
                                    new Car{ CarId = 2, BrandId = 1, ColorId = 3, ModelYear = 2019, DailyPrice = 820, DescriptionOfCar = "2.0 Benzinli Manuel"},
                                    new Car{ CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 680, DescriptionOfCar = "1.0 Benzinli Otomatik"},
                                    new Car{ CarId = 4, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 630, DescriptionOfCar = "1.0 Benzinli Otomatik"},
                                    new Car{ CarId = 5, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 590, DescriptionOfCar = "1.3 Benzinli Manuel"},
                                    new Car{ CarId = 6, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 550, DescriptionOfCar = "1.3 Benzinli Manuel"},
                                    new Car{ CarId = 7, BrandId = 4, ColorId = 2, ModelYear = 2018, DailyPrice = 480, DescriptionOfCar = "1.5 Dizel Manuel"},
                                    new Car{ CarId = 8, BrandId = 5, ColorId = 2, ModelYear = 2018, DailyPrice = 450, DescriptionOfCar = "1.6 Dizel Manuel"},
                                    new Car{ CarId = 9, BrandId = 5, ColorId = 4, ModelYear = 2019, DailyPrice = 600, DescriptionOfCar = "1.6 Benzinli Manuel"}
                                   };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete; // Referans tutucu
            // _cars listesindeki itemları dönerken parametrede verilen car'ın id bilgisiyle eşleşen liste elemanının referansını carToDelete'e aktar.
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId); 
            _cars.Remove(carToDelete); // ıd bilgisi eşleşen liste elemanını sil.
        }

        public Car GetById(int carId)
        {
            return _cars.Find(c => c.CarId == carId);
           
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId); // _cars içersindeki elemanları dön, id eşleşmesini yakala.
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.DescriptionOfCar = car.DescriptionOfCar;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
