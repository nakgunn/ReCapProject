using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Delete(Color color);
        void Update(Color car);
        List<Color> GetAll();
        Color GetColorById(int id);
    }
}
