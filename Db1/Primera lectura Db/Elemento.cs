﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_lectura_Db
{
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
