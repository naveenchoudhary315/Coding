using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
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


namespace SingletonThreadSafe
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _lock = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}


namespace SingletonThreadSafeWithLazy
{

    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }

    }
}
