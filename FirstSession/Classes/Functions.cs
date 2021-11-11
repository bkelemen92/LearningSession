using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSession.Classes
{
    public class Functions
    {
        public static double FutureValue2(double pv, double r, double n)
        {
            return pv * (1 + r / 100 * n);
        }
    }
}
