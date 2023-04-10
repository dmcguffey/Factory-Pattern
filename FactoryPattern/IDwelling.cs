using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IDwelling
    {
        public string Roof { get; set; }
        public bool hasChimney { get; set; }

        public int Bedrooms { get; set; }

        public string Kitchen { get; set; }

        public void build();
    }
}
