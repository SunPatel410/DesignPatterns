using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{  /// <summary>
   /// The 'Subject interface
   /// defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.
   /// </summary>
    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}
