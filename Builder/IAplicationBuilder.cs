using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public interface IApplicationBuilder
    {
        void SetName();
        void SetDescription();
        void SetDependencies();

        Application GetApplication();
    }
}
