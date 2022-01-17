using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonTasarım_Kalıbı
{
    class Singleton
    {
        private static Singleton instance;
         public string ad { get; set; }
        
        private Singleton()
        {
                 ad= "umut";
        }
        
        public static Singleton GetSingleton()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            else
            {
                instance.ad = "kopya";
            }
            return instance;
        }
    }
}
