using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApplication
{
    public class Offerlist
    {
        public string ShopName, PizzaName, Size;
        public string[] Elements;
        public int Cost, Id;
        public Offerlist()
        {
            ShopName = PizzaName = Size = null;
            Cost = 0;
            Elements = null;
            Id = 1;
        }
        ~Offerlist() { }
    }
    public class Shoplist : Offerlist
    {
        public int In;
    }
}
