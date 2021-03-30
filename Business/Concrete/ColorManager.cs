using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            //iş kodları

            return _colorDal.GetAll();
        }

        public Color GetByColorID(int colorId)
        {
            return _colorDal.Get(c => c.ColorId == colorId);
        }
    }
}
