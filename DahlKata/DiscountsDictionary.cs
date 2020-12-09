using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahlKata
{
    public class DiscountsDictonary
    {
        public Dictionary<int, double> discounts = new Dictionary<int, double>
        {
            {1, 0},
            {2, 0.05},
            {3, 0.10},
            {4, 0.20},
            {5, 0.25}
        };
    }
}