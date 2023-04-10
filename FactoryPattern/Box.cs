using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Box : IDwelling
    {
        public string Roof { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasChimney { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Bedrooms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Kitchen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void build()
        {
            Console.WriteLine("No need to build. I have one in the attic you're welcome to.");
        }
    }
}
