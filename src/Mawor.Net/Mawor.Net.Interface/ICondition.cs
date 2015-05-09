using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// A condition is a Set of rule
    /// </summary>
    interface ICondition
    {
        /// <summary>
        /// Checks if the condition stored is valid or not
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        bool IsValid(IContext context);

        //TODO: Add expression/Mechanism for validation
    }
}
