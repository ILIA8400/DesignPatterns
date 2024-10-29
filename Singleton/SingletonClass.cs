using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static SingletonClass _instance;
        private SingletonClass() { }
 
        public static SingletonClass GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonClass();
            }

            return _instance;
        }

    }
}
