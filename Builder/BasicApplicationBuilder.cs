using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class BasicApplicationBuilder : IApplicationBuilder
    {
        private readonly Application _application;
        public BasicApplicationBuilder()
        {
            _application = new Application();
        }
        public Application GetApplication()
        {
            return _application;
        }

        public void SetDependencies()
        {
            _application.Dependencies = "Basic Dependencies";
        }

        public void SetDescription()
        {
            _application.Description = "Basic Description";
        }

        public void SetName()
        {
            _application.Name = "Basic Application";
        }
    }
}
