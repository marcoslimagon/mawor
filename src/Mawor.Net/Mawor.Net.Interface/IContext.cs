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
        object Target { get;  }
        
        /// <summary>
        /// Usually 
        /// </summary>
        ContextType TargetType { get; }

         
    }

    public enum ContextType
    {
        Instance,
        Method,
        Event,
        Delegate
    }
}
