using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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


        public IResult Add(Car car)
        {
            if (car.DescriptionOfCar.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult("Araç eklenemedi");
            }            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<Car> GetCarById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.CarId==id), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(), Messages.AllCarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.BrandId == BrandId), Messages.CarsFilteredByBrand);
        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), Messages.CarsFilteredByColor);
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarsDetails(), Messages.CarDetailsListed);
        }
    }
}
