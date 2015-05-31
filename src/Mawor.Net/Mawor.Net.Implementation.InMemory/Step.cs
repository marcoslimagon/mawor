using Mawor.Net.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory
{
    public class Step:WorkflowItem,IStep<Guid>
    {
        private IList<ITransition<Guid>> _transitions;

        public Step()
        {
            _transitions = new List<ITransition<Guid>>();
        }

        public Step(IStep<Guid> parentStep):this()
        {
            this.Parent = parentStep;
        }

        public ICollection<ITransition<Guid>> Transitions
        {
            get { return _transitions; }
        }




        public IStep<Guid> Parent
        {
            get;
            set;
        }
    }
}
