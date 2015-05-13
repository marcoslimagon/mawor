using Mawor.Net.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory
{
    public class WorkflowItem : IExtensible, IIdentifiable<Guid>
    {
        public WorkflowItem()
        {
            _extendedProperties = new Dictionary<string, IProperty>();
        }

        #region IExtensible Members
        private IDictionary<string, IProperty> _extendedProperties;
        public ICollection<IProperty> ExtendedProperties
        {
            get { return this._extendedProperties.Values; }
        }

        public void AddExtendedProperty(IProperty property)
        {
            _extendedProperties.Add(property.Name, property);
        }

        public IProperty GetExtendedProperty(string name)
        {
            IProperty property = null;

            if (_extendedProperties.ContainsKey(name))
            {
                property = _extendedProperties[name];
            }


            if (property == null)
            {
                property = new ExtendedProperty();
                property.Name = name;
                property.Type = null;
                this.AddExtendedProperty(property);
            }

            return property;
        }

        public void ClearExtendedProperties()
        {
            this._extendedProperties.Clear();
        }

        public void RemoveExtendedProperty(string name)
        {
            this._extendedProperties.Remove(name);
        }
        #endregion


        #region IIdentifiable Members

        private Guid _id;

        public Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        private string _description;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public bool Equals(Guid other)
        {
            return this.Id.Equals(other);
        }
        #endregion
    }
}
