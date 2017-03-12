using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exception =char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = start; i <= end; i++)
            {
                for (char a = start; a <= end; a++)
                {
                    for (char b = start; b <= end; b++)
                    {
                        if (i != exception && a != exception && b != exception)
                        {
                            count++;
                            Console.Write("{0}{1}{2} ", i, a, b);
                            
                        }
                        else
                        {
                            continue;
                        }
                        
                    }
                }
            }
            Console.Write("{0} ",count);


        }
    }
}
