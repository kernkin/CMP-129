using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface myInterface
{
    void Read();
}

class TestInterface : myInterface
{
    public void Read()
    {
        Console.WriteLine("Fluffy");
    }
}

namespace Interface
{
    class Program
    {
        static void Main()
        {
            myInterface Interfaces = new TestInterface();
            Interfaces.Read();
        }
    }
}
