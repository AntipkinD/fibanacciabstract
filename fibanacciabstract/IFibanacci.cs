using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibanacciabstract
{
    public interface IFibanacci
    {
        internal static void Fibanacci<T>(dynamic n)
        {
            if (n == 0) Console.WriteLine(0);
            dynamic prev = 0;
            Console.Write(prev + " ");
            dynamic next = 1;
            Console.Write(next + " ");
            for (int i = 2; i < n; i++)
            {
                dynamic sum = prev + next;
                prev = next;
                next = sum;
                Console.Write(next + " ");
            }
        }
    }
}
