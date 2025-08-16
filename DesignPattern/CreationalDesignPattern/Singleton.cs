using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        // Private constructor to prevent instantiation from outside

        private Singleton()
        {
            // Initialization code here
        }

        // Public property to provide access to the instance

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
