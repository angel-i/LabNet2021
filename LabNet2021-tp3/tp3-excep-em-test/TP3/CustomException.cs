﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
  public  class CustomException : Exception
    {
        public CustomException() : base("este metodo devuelve true") { 
        
        }

            
    }
}
