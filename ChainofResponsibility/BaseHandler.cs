using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
    }
}
