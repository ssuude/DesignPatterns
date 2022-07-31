using System;
namespace SingletonDesing
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton mySingleton= MySingleton.Instance;
            mySingleton.Yazdir();
        }
    }
    public class MySingleton
    {
        private static MySingleton instance= null;
        private MySingleton() { }
        public static MySingleton Instance
        {
            get 
            { 
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                return instance;
            }
        }
        public  void Yazdir()
        {
            Console.WriteLine("Singleton sınıfı çağırıldı. ");
            Console.ReadLine();
        }
    }
}