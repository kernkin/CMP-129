using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an event manager that has at least 3 different events. Allow the user to type events into the console and
//have the appropriate event called (or not called if it's not valid event)

namespace projectEulerInterface
{
    interface myInterface
    {
        void Compute();
    }
   
    public delegate void MyDelegate(object sender, EventArgs e);
    public class EventManager
    {
        private static EventManager manager;
        private Dictionary<string, MyDelegate> events = new Dictionary<string, MyDelegate>();
        public static EventManager Manager
        {
            get
            {
                if(manager == null)
                {
                    manager = new EventManager();
                }
                return manager;
            }
        }
        private EventManager(){}

        public void Happen(string eventName)
        {
            if (!events.Keys.Contains(eventName)) return;
            if (events[eventName] != null)
            {
                events[eventName](this, EventArgs.Empty);
            }
        }
        public void Subscribe(string eventName, MyDelegate subscriber)
        {
            if (!events.Keys.Contains(eventName))
            {
                events.Add(eventName, null);           
                {

                }
                events[eventName]+= subscriber;
            }
        }

            public void Forget(string eventName, MyDelegate subscriber)
            {
                if (events.Keys.Contains(eventName))
                {
                    events[eventName] -= subscriber;
                }
            }
    }   

     public class One : myInterface
    {
        public void Compute() 
        {
            
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

     public class Two : myInterface
     {
         public void Compute()
         {
            
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

     public class Three : myInterface
     {
         public void Compute()
         {
            
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
     }

     public class Nine : myInterface
         {
             public void Compute()
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
        static void Main(string[]args )
        {
            EventManager.Manager.Subscribe("ButtonPressed", MySubscriber);
            EventManager.Manager.Subscribe("ButtonPressed", MySubscriber);
            EventManager.Manager.Subscribe("ButtonPressed", MySubscriberReleased);
            EventManager.Manager.Happen("ButtonPressed");
            EventManager.Manager.Happen("ButtonPressed");
        }
        static void MySubscriberReleased(object sender, EventArgs e)
        {
            Console.WriteLine("button released");
        }
        static void MySubscriber(object sender, EventArgs e)
        {
            Console.WriteLine("button pressed");
        }
    }

            //List<myInterface> list = new List<myInterface>();
            //list.Add(new One());
            ////list.Add(new Two());
            ////list.Add(new Three());
            //list.Add(new Nine());

            //foreach(myInterface compute in list)
            //{
            //    compute.Compute();
            //}
        //}
    //}
}
