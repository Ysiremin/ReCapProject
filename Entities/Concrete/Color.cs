﻿using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public int colorId { get; set; }
        public string colorName { get; set; }
    }
}
