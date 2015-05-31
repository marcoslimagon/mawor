using Mawor.Net.Interface;
using Mawor.Net.Interface.Provider;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mawor.Net.Implementation.InMemory.Provider
{
    public class InMemoryIdentityProvider:IIdentityProvider<Guid>
    {

        private Dictionary<Guid, IIdentifiable<Guid>> _objects;

        public InMemoryIdentityProvider()
        {
            _objects = new Dictionary<Guid, IIdentifiable<Guid>>();
        }

        public void SetId(Interface.IIdentifiable<Guid> identifiable)
        {
            Guid uniqueKey = CreateUniqueGuid();
            identifiable.Id = uniqueKey;

            _objects.Add(uniqueKey, identifiable);
        }

        private Guid CreateUniqueGuid()
        {

            var guid = Guid.NewGuid();

            while (_objects.ContainsKey(guid))
            {
                guid = Guid.NewGuid();
            }

            return guid;
        }
    }
}
