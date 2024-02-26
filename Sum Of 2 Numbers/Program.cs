using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_2_Numbers
{
    
    public class Program
    {
        public static float Sum(float num1,float num2)    //Manual Test
        {
            return (num1 + num2);
        }
        static void Main(string[] args)
        {
            float result=Sum(1, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
