using Mawor.Net.Interface.Provider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory.Provider
{
    public class InMemoryWorkflowProvider : IWorkflowProvider<Guid>
    {
        private IIdentityProvider<Guid> _idProvider;

        public InMemoryWorkflowProvider(IIdentityProvider<Guid> idProvider)
        {
            this._idProvider = idProvider;
        }

        public Interface.IWorkflow<Guid> CreateNewWorkflow()
        {
            var item =
            new Worflow();

            _idProvider.SetId(item);

            return item;
        }

        public Interface.IStep<Guid> CreateNewStep()
        {
            var item =
             new Step();

            _idProvider.SetId(item);

            return item;
        }

        public Interface.ITransition<Guid> CreateNewTransition(Interface.IIdentifiable<Guid> from, Interface.IIdentifiable<Guid> to)
        {
            var item =
             new Transition();

            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            item.From = from;
            item.To = to;

            _idProvider.SetId(item);

            return item;
        }


        public Interface.IWorkflow<Guid> CreateNewWorkflow(Interface.IStep<Guid> parentStep)
        {
            var item =
           new Worflow(parentStep);

            _idProvider.SetId(item);

            return item;
        }

        public Interface.IStep<Guid> CreateNewStep(Interface.IStep<Guid> parentStep)
        {
            var item =
             new Step(parentStep);

            _idProvider.SetId(item);

            return item;
        }

        public void SetParent(Interface.IStep<Guid> target, Interface.IStep<Guid> parent)
        {
            var step = target as Step;

            if (step != null)
            {
                step.Parent = parent;
            }
        }
    }
}
