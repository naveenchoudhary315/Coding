using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesingPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        // Private constructor prevents external instantiation
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
