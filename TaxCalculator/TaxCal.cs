using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class TaxCal
    {
        public double item1;
        public double mcTax_rate = 0.65;

        public double GetAmount()
        {
            return item1;
        }
        public double cFindTax(double cAmount)
        {
            double FindTax = cAmount - (cAmount * mcTax_rate);
            return FindTax;
        }
    }
}
