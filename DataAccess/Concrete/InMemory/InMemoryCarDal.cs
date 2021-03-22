using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car{ Id = 1, BrandId = 1, ColorId = 4, ModelYear = 2018, DailyPrice = 375, Description = "1.4 Dizel Otomatik" },
                                    new Car{ Id = 2, BrandId = 1, ColorId = 3, ModelYear = 2019, DailyPrice = 820, Description = "2.0 Benzinli Manuel"},
                                    new Car{ Id = 3, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 680, Description = "1.0 Benzinli Otomatik"},
                                    new Car{ Id = 4, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 630, Description = "1.0 Benzinli Otomatik"},
                                    new Car{ Id = 5, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 590, Description = "1.3 Benzinli Manuel"},
                                    new Car{ Id = 6, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 550, Description = "1.3 Benzinli Manuel"},
                                    new Car{ Id = 7, BrandId = 4, ColorId = 2, ModelYear = 2018, DailyPrice = 480, Description = "1.5 Dizel Manuel"},
                                    new Car{ Id = 8, BrandId = 5, ColorId = 2, ModelYear = 2018, DailyPrice = 450, Description = "1.6 Dizel Manuel"},
                                    new Car{ Id = 9, BrandId = 5, ColorId = 4, ModelYear = 2019, DailyPrice = 600, Description = "1.6 Benzinli Manuel"}
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
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id); 
            _cars.Remove(carToDelete); // ıd bilgisi eşleşen liste elemanını sil.
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
           
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); // _cars içersindeki elemanları dön, id eşleşmesini yakala.
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }


    }
}
