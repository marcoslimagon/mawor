using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Transition is the link between identifiable objects. Commonly is used to link two Steps.
    /// </summary>
    /// <typeparam name="T">type of the identification of the transition</typeparam>
    /// <typeparam name="U">type of the steps Identification</typeparam>
    public interface ITransition<T,U>:IIdentifiable<T>,IExtensible
    {
        IIdentifiable<T> From { get; set; }
        IIdentifiable<U> To { get; set; }
    }
}
