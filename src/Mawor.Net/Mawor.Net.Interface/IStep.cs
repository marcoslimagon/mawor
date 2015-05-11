using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Step or Task, atomic and represents a determined state.
    /// </summary>
    /// <typeparam name="T">The type of the identfication, preferred int or Guid</typeparam>
    public interface IStep<T>:IIdentifiable<T>,IExtensible
    {
        ICollection<ITransition<T>> Transitions { get; }

        void AddTransition(ITransition<T> transition);
        void RemoveTransition(ITransition<T> transition);
        void ClearTransitions();
    }
}
