using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenInside = 0;
            int evenOutside = (n / 2) - 1;

            int oddInside = 1;
            int oddOutside = n / 2;

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', evenOutside), new string('-', evenInside));
                    evenInside += 2;
                    evenOutside--;
                }
                evenOutside += 2;
                evenInside -= 4;

                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', evenOutside), new string('-', evenInside));
                    evenInside -= 2;
                    evenOutside++;
                }
            }
            else
            {
                Console.WriteLine("{0}*{0}", new string('-', oddOutside));
                oddOutside--;
                for (int i = 0; i <= (n / 2 - 1); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', oddOutside), new string('-', oddInside));
                    oddOutside--;
                    oddInside += 2;
                }
                oddOutside += 2;
                oddInside -= 4;

                for (int i = 0; i < (n / 2 - 1); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', oddOutside), new string('-', oddInside));
                    oddOutside++;
                    oddInside -= 2;
                }
                Console.WriteLine("{0}*{0}", new string('-', oddOutside));
            }
        }
    }
}
