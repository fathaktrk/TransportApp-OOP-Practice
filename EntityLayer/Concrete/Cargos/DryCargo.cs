﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Cargos
{
    public class DryCargo : ICargo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}