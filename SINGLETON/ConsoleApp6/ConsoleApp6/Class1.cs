using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   class Program
    {
        static void Main(string[] args)
        {
            //Singleton singleton = new Singleton();
            //Console.WriteLine(singleton.GetText());
            
            //**Dışardan çaığrabilmek için:
            Console.WriteLine(Singleton.GetInstance().GetText());
        }
    }
}
