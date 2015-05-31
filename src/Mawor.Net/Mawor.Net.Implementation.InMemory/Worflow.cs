using Mawor.Net.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory
{
    public class Worflow:Step,IWorkflow<Guid>
    {
        public Worflow():base()
        {
        }

        public Worflow(IStep<Guid> parentStep)
            : base(parentStep)
        {
        }

        public IStep<Guid> DefaultStep
        {
            get;
            set;
        }
    }
}
