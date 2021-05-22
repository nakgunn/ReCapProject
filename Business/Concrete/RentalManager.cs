using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {

            var lastRentedCar = _rentalDal.GetAll().FindLast(r => r.CarId == rental.CarId);
            
            if (lastRentedCar == null || ( lastRentedCar !=null && lastRentedCar.ReturnDate < rental.RentDate))
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }

            else if (lastRentedCar != null && lastRentedCar.ReturnDate > rental.RentDate)
            {
                return new ErrorResult(Messages.carIsNotReturned);
            }

            else
            {
                return new ErrorResult("Else çalıştı");
            }
         
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            throw new NotImplementedException();
        }
    }
}
