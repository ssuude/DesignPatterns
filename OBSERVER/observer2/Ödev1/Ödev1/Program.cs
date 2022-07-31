using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("***********************1.KISIM **********************");
                string mail;
                string[] a;
                Console.WriteLine("Mail adresinizi giriniz:");
                mail = Console.ReadLine();
                a = mail.Split('@');
                foreach (string kullanıcıad in a)
                {
                    Console.WriteLine("Kullanıcı adı:" + kullanıcıad);
                    Console.WriteLine("Domain :"+ kullanıcıad);
                }
                
            }
            {
                Console.WriteLine("**********************2. KISIM***********************");
                string cümle;
                string[] s;
                Console.Write("Cümle giriniz:");
                cümle = Console.ReadLine();
                s = cümle.Split(' ');
                foreach (string kelime in s)
                {
                    Console.WriteLine("donus :"+kelime);

                }
            }
            Console.ReadKey();

        }
    }
}
