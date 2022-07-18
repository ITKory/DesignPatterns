using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product;
        public ConcreteBuilder()
        {
            _product = new Product();
        }
        public void Reset() => _product = new ();
        public void BuildPartA() => _product.Add("PartA");

        public void BuildPartB() => _product.Add("PartB1");

        public void BuildPartC() => _product.Add("PartC1");
        public Product GetProduct()
        {
            Product result = _product;
            Reset();
            return result;
        }

    }
}
