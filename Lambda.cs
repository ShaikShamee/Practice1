using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    public class Lambda:accessModifier
    {
        static void Main(string[] args)
        {
         List<int> numbers = new List<int>() {36, 71, 12, 15, 29, 18, 27, 17, 9, 34};
            Console.Write("The list : ");
            
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();
            var square = numbers.Select(x => x * x);
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();

            Lambda lbda = new Lambda();
            lbda.Name = "Shaik seema";
            Console.WriteLine(lbda.Name);
            lbda.Age = 25;
            Console.WriteLine(lbda.Age);
            lbda.Email = "shaikseema@gmail.com";
            Console.WriteLine(lbda.Email);
            lbda.PhoneNumber = 7869089076;
            Console.WriteLine(lbda.PhoneNumber);
            Console.ReadLine();

          
        }
    }
}
