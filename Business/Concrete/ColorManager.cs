using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            this._colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);

        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetColorById(int id)
        {
            return _colorDal.Get(clr => clr.ColorId == id);
        }

        public void Update(Color car)
        {
            _colorDal.Update(car);

        }
    }
}
