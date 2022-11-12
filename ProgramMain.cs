using System;
using System.Threading.Tasks;

namespace Singleton
{
    class ProgramMain
    {


        public static void ObjectMethod1()
        {
            SingletonClass obj = SingletonClass.getInstance();

        }
        public static void ObjectMethod2()
        {
            SingletonClass obj1 = SingletonClass.getInstance();
        }
        static void Main(string[] args)
        {

            Parallel.Invoke(
            () => { ObjectMethod1(); },
            () => { ObjectMethod2(); }
                     );

            Console.ReadLine();

        }
    }
}
