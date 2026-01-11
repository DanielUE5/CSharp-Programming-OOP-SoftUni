using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            return number.All(char.IsDigit) && number.Length == 10
                ? $"Calling... {number}"
                : "Invalid number!";
        }

        public string Browse(string url)
        {
            return url.Any(char.IsDigit)
                ? "Invalid URL!"
                : $"Browsing: {url}!";
        }
    }
}
