using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Context is a method, instance, property or any kind of reflective object used for make
    /// </summary>
    public interface IContext:IExtensible
    {
        object ContextItem { get;  }
    }

    public interface IContext<T> : IContext
    {
        T ContextObject { get; }
    }
}
