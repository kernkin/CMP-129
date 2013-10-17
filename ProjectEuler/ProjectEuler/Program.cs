using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//complete problems 1, 2 ,5 and 2 of your choosing Attribute projecteuler.net
//
namespace ProjectEuler
{
    class Program
    {
        //problem1
        static void Main(string[] args)
        {

                        


            List<int> numbers = new List<int>();
            for (int i = 3; i < 1000; i += 3)
            {
                numbers.Add(i);
                
            }
            
            for (int x = 5; x < 1000; x += 5)
            {
                numbers.Add(x);
            }
            numbers.ForEach(Console.WriteLine);
            int sum1 = numbers.Sum();
            Console.WriteLine(sum1);
            Console.ReadLine();
        }        
    }
    public class problem2
    {
 
    }
}
