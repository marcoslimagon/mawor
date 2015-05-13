using Mawor.Net.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory
{
    class Step:WorkflowItem,IStep<Guid>
    {
        public ICollection<ITransition<Guid>> Transitions
        {
            get { throw new NotImplementedException(); }
        }

        public void AddTransition(ITransition<Guid> transition)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransition(ITransition<Guid> transition)
        {
            throw new NotImplementedException();
        }

        public void ClearTransitions()
        {
            throw new NotImplementedException();
        }
    }
}
