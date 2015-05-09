using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Represents an identifiable object
    /// </summary>
    /// <typeparam name="T">Type of the identification, preferred Guid or Int</typeparam>
    public interface IIdentifiable<T>:IEquatable<T>
    {
        /// <summary>
        /// Unique value that represents an object among the collection of objects of all workflows
        /// </summary>
        T Id { get; set; }

        /// <summary>
        /// Descriptive value, the same as Name
        /// </summary>
        string Description { get; set; }
    }
}
