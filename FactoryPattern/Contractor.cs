using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class Contractor
    {
        public static IDwelling buildHome(string home)
        {
            switch (home.ToLower()) //changes user input to lowercase
            {
                case "family home":
                    return new FamilyHome();
                case "rv":
                    return new RV();
                case "box":
                    return new Box();
                default:
                    return new FamilyHome();
            }
        }
    }
}
