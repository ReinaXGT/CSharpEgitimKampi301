using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; } //Primary Key

        public string ProductName { get; set; }

        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; } //Foreign Key

        public virtual Category Category { get; set; }

        public List<Order> Orders { get; set; }

        //virtual ise lazım olunca getir demektir.
        //Lazy loading diyebiliriz buna.
        //bunun ekstra bir faydası da sistemi yormaz.

    }
}
