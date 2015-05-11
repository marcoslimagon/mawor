using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Used by structures that supports extended properties.
    /// Extended properties are arbitrary properties that can be added to an element
    /// </summary>
    public interface IExtensible
    {

        /// <summary>
        /// Gets a list of extended properties
        /// </summary>
        ICollection<IProperty> ExtendedProperties { get; }

        /// <summary>
        /// Add a new Extended Property
        /// </summary>
        /// <param name="property"></param>
        void AddExtendedProperty(IProperty property);

        /// <summary>
        /// Get extended property by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IProperty GetExtendedProperty(string name);

        /// <summary>
        /// Remove all the extended properties
        /// </summary>
        void ClearExtendedProperties();

        /// <summary>
        /// Remove specific extended property
        /// </summary>
        /// <param name="name"></param>
        void RemoveExtendedProperty(string name);
    }
}
