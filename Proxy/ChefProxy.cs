using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ChefProxy : IChef 
    {
        private readonly IChef _chef;

        private IDictionary<int, string>? _statuses;
        public ChefProxy(IChef chef)
        {
            _chef = chef;
        }
        public string Name => _chef.Name;
        public List<Order> GetOrders()  =>  _chef.GetOrders();
        public IDictionary<int, string> GetStatuses()
        {
            // add statuses to cache
            if (_statuses is null)
                _statuses = _chef.GetStatuses();
            return _statuses;
        }
    }
}
