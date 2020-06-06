using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErickAula1.AlterProduct
{
    public class Alter
    {
        private int AtIndex;
        private string AlterProduct;

        public int GetIndex { get { return AtIndex; } }
        public string GetProduct { get { return AlterProduct; } }

        public Alter(int index, string Product)
        {
            this.AtIndex = index;
            this.AlterProduct = Product;
        }
    }
}
