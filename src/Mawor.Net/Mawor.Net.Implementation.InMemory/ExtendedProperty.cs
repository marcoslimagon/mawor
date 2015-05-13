using Mawor.Net.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory
{
    public class ExtendedProperty : IProperty
    {

        private object _value;

        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
               this._value = value;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name ;
            }
            set
            {
                this._name = value;
            }
        }

        private Type _type;

        public Type Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value ;
            }
        }
    }
}
