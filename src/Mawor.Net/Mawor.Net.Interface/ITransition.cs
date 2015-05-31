using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Transition is the link between identifiable objects. Commonly is used to link two Steps.
    /// </summary>
    /// <typeparam name="T">type of the identification of the transition</typeparam>
    public interface ITransition<T>:IIdentifiable<T>,IExtensible
    {
        IIdentifiable<T> From { get; set; }
        IIdentifiable<T> To { get; set; }
    }
}
