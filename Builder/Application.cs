using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class Application
    {
        public string Dependencies { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public void Run()
        {
            Console.WriteLine("Application was created.");
            Console.WriteLine($"Dependencies : {Dependencies}   Name : {Name}   Description : {Description}");
        }
    }
}
