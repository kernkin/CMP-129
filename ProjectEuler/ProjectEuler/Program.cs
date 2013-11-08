using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//complete problems 1, 2 ,5 and 2 of your choosing Attribute projecteuler.net
//Write an event manager that has at least 3 different evnts. Allow the user to type events into the console and
//have the approproate event called (or notcalled if it's not valid event
interface myInterface
{
    void Read();
}

namespace ProjectEuler
{

    public class Problem1 : myInterface
    {
        public void One : 
        {
            get
            {
                List<int> numbers = new List<int>();
                for (int i = 3; i < 1000; i += 3)
                {
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
        }
    }



    public class Problem2
    {
       public void Two
        {
           get
            {
                var sum = 0;
                var x = 0;
                var y = 1;
                int nextFib;
                do
                {
                    nextFib = x + y;
                    if (nextFib % 2 == 0)
                        sum += nextFib;

                    x = y;
                    y = nextFib;
                } while (nextFib < 4000000);

                Console.WriteLine(sum);
                
            }
        }
    }

    public class Three
    {
        public void Five
        {
            get
            {
                bool bDivisibleby10 = false;
                int currentNum = 0;
                while (true)
                {
                    currentNum++;

                    for (int i = 1; i <= 20; i++)
                    {
                        if ((currentNum % i) == 0)
                        {
                            bDivisibleby10 = true;
                        }
                        else
                        {
                            bDivisibleby10 = false;
                            break;
                        }

                    }
                    if (bDivisibleby10)
                    {
                        Console.WriteLine("Answer : " + currentNum);
                        break;

                    }
                }
            }
        }

        public class Nine
        {
            public void Nine
            {
                get
                {
                    for (int a = 1; a < 1000; a++)
                    {
                        for (int b = 1; b < 1000; b++)
                        {
                            double Asquare = Math.Pow(a, 2);
                            double Bsquare = Math.Pow(b, 2);
                            double Csquare = Math.Sqrt(Asquare + Bsquare);
                            if ((a + b + Csquare) == 1000.00)
                            {
                                Console.WriteLine("a " + a + " b " + b + " c " + Csquare + " product : " + (a * b * Csquare));
                                break;
                            }
                        }
                    }

                }
            }




            class Program
            {
                //problem1
                static void Main(string[] args)
                {
                    Console.WriteLine();

                    List<int> numbers = new List<int>();
                    
                }
            }
        }

    }
}

  /*for (int i = 3; i < 1000; i += 3)
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
                    Console.ReadLine();*/