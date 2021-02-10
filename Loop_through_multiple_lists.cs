using System;
using System.Linq;

namespace GitHub_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Hello", "Test", "bye" };
            int[] numbers = new int[] { 1, 2, 3 };
            char[] signs = new char[] {'?','$','!' };

            var forged = names.Zip(numbers, (n, e) => new { n, e }).Zip(signs, (x, s) => new { Names = x.n, Numbers = x.e, Signs = s });
            foreach (var item in forged)
            {
             
                Console.WriteLine(string.Join(", ", item.Names, item.Numbers, item.Signs));
            }


        }
    }
}
