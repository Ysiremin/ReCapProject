using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetByColorID(int colorId);
    }
}
