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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.AllUsersListed);

        }

        public IDataResult<User> GetUserByEmail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email), Messages.UserListed);
        }

        public IDataResult<User> GetUserById(int id)
        {

            return new SuccessDataResult<User>(_userDal.Get(u=>u.UserId==id),Messages.UserListed);

        }

        public IDataResult<List<User>> GetUsersByName(string name)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.UserName == name), Messages.AllUsersListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();

        }
    }
}
