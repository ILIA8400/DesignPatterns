using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySample1
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading " + _fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + _fileName);
        }
    }
}
