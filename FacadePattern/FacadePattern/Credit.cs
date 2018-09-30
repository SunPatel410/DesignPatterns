using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
/// <summary>
/// >> Subsystem Class
/// implement subsystem functionality.
///  handle work assigned by the Facade object.
///  have no knowledge of the facade and keep no reference to it.
/// </summary>
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine($"Check credit for {customer.Name}");
            return true;
        }
    }
}
