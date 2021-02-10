using System;
using System.Linq;

namespace GitHub_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Hello", "Test", "bye" };
            int[] integer = new int[] { 1, 2, 3 };
            char[] signs = new char[] {'?','$','!' };
    
            var forged = names.Zip(integer, (names, integer) => new { names, integer }).Zip(signs, (newstring, signs) => new { Names = newstring.names, Numbers = newstring.integer, Signs = signs });
            
            foreach (var item in forged)
            {
             
                Console.WriteLine(string.Join(", ", item.Names, item.Numbers, item.Signs));
            }


        }
    }
}
