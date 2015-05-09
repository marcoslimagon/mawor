using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Interface
{
    /// <summary>
    /// Used by structures that supports extended properties
    /// </summary>
    public interface IExtensible
    {
        ICollection<IProperty> ExtendedProperties { get; }

        void AddExtendedProperty(IProperty property);

        IProperty GetExtendedProperty(string name);

        void ClearExtendedProperties();

        void RemoveExtendedProperty(string name);
    }
}
