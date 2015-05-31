using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface.Provider
{
    public interface IWorkflowProvider<T>
    {
        IWorkflow<T> CreateNewWorkflow();
        IWorkflow<T> CreateNewWorkflow(IStep<T> parentStep);
        IStep<T> CreateNewStep();
        IStep<T> CreateNewStep(IStep<T> parentStep);
        ITransition<T> CreateNewTransition(IIdentifiable<T> from, IIdentifiable<T> to);
        void SetParent(IStep<T> target, IStep<T> parent);
    }
}
