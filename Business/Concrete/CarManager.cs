using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal) 
        {
            this._carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DescriptionOfCar.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç başarıyla eklendi: " + car.DescriptionOfCar);
            }
            else
            {
                Console.WriteLine("Araç açıklaması 2 karakterden uzun, Günlük kiralık ücreti 0 TL'den büyük olmalıdır");
            }            
        }

        public object GetById(int v)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car GetCarById(int id)
        {
            return _carDal.Get(c=>c.CarId==id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }
        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
