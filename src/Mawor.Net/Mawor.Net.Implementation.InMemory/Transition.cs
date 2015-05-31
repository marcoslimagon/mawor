using Mawor.Net.Interface;
using Mawor.Net.Interface.Provider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory
{
    public class Transition : WorkflowItem, ITransition<Guid>
    {

        public IIdentifiable<Guid> From
        {
            get;
            set;
        }

        public IIdentifiable<Guid> To
        {
            get;
            set;
        }
    }
}
