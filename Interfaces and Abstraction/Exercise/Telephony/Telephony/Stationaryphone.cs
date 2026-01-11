using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            return number.All(char.IsDigit) && number.Length == 7
                ? $"Dialing... {number}"
                : "Invalid number!";
        }
    }
}
