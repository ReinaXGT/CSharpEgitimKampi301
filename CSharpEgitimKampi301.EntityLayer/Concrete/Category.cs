using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        // primary key için sınıf+Id takası yazılmalıdır.
        // mesela abcId olsa olmaz class Category şuan.


        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }

    }
}


/*
    Field-Variable-Property
    
    int x; // field
    
    public int y {get; set;} // property

    void test()
    {
        int z; // variable
    }
 
 */