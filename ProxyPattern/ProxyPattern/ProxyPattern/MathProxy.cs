using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class MathProxy : IMath
    {
        /// <summary>
        /// The 'Proxy Object' class
        ///This class will be used by the applications and will expose the methods exposed by the Subject. 
        /// The application will use this class and this class will internally take care of talking to the RealSubject and
        /// get the data to the local application.
        /// </summary>
        private Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }
    }
}
