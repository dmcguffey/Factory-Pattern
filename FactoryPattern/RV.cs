﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class RV : IDwelling
    {
        public string Roof { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasChimney { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Bedrooms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Kitchen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void build()
        {
            Console.WriteLine("Let's customize an RV! Roadtrip!");
        }
    }
}
