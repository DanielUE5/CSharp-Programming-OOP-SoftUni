using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random _random = new Random();

        public string RandomString()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            int index = _random.Next(Count);
            string randomElement = this[index];
            RemoveAt(index);

            return randomElement;
        }
    }
}
