using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum CategoryofGoods
    {
        Food,
        Appliance
    }

   public class Product
    {
        public string NameofGood { get; set;}

        public int PriceGood { get; set;}

        public int  CodeofGood { get; set;}

        public CategoryofGoods CategoryofGood { get; set; }
        public override string ToString()
        {
            return NameofGood;

        }
    }
}
