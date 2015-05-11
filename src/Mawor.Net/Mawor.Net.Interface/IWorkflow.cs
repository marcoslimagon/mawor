using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// This class represents a workflow. 
    /// A workflow is a complete process with the beggining and end. It contains a set of steps.
    /// </summary>
    /// <typeparam name="T">Type of the identity value</typeparam>
    /// <typeparam name="U">Type of the identification for the steps</typeparam>
    public interface IWorkflow<T>:IStep<T>
    {
        /// <summary>
        /// The first step (or workflow item) of the workflow
        /// </summary>
        IStep<T> DefaultStep { get; set; } 
    }
}
