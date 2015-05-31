using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface.Provider
{
    public interface IIdentityProvider<T>
    {
        void SetId(IIdentifiable<T> identifiable);
    }
}
