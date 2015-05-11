using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Defines the base structure for the extended properties
    /// </summary>
    public interface IProperty
    {
        /// <summary>
        /// Value of the extended property
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Name of the extended property
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Type of the extended property
        /// </summary>
        Type Type { get; set; }
    }
}
