using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class Builder
    {
        private readonly IApplicationBuilder _builder;

        public Builder(IApplicationBuilder builder)
        {
            this._builder = builder;
        }

        public void BuildName()
        {
            _builder.SetName();
        }

        public void BuildDescription()
        {
            _builder.SetDescription();
        }

        public void BuildDependencies()
        {
            _builder.SetDependencies();
        }

        public Application Build()
        {
            return _builder.GetApplication();
        }
    }
}
