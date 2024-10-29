using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample1
{
    public class Manager
    {
        private static Manager instance;
        private Manager() { }
        
        public static Manager CreateInstance()
        {
            if (instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }

    }
}
