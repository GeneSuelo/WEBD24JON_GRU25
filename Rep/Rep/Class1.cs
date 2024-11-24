using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rep
{
    public class Class1
    {
        public double CalcAverage(int[] num)
        {
            if (num == null || num.Length == 0) //Om arrayen är tom ska metoden returnera 0
            {
                return 0;
            }

            double sum = 0;

            //Loopa genom arrayen och summera alla värden
            foreach (int numer in num)
            {
                sum += numer;
            }

            //Dela summan med antalet värden i arrayen för att få genomsnittet
            double avr = sum / num.Length;
            return avr;
        }
    }
}
