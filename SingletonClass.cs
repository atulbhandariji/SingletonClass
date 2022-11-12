using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public  sealed class SingletonClass
    {
        private static SingletonClass instance = null;
        private static int counter = 0;
        private static readonly object objlock = new object();

        private SingletonClass()
        {
            counter++;
            Console.WriteLine(counter.ToString()+ " " + "hello i am private constructor from singleton class");
        }
        public static SingletonClass getInstance()
        {
            lock (objlock)
            {
                if (instance == null)
                {
                    instance = new SingletonClass();
                }
            }
            return instance;
        }   
    }
}



