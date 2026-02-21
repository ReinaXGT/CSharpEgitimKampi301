using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext
    {

        //Pluralize yani çoğul yaparak yazmak bir standarttır. O yüzden Category yerine Categories yazdık.
        //C# tarafında category olarak yazdık ama sql tarafında categories olarak görünecektir. Çünkü sql tarafında çoğul yaparak yazmak bir standarttır.
        public DbSet<Category> Categories { get; set; }
        //DbSetin  içindeki sınıfımızın ismi Yanındaki yani Categories ise sql tarafındaki sütünun ismi.
        //DbSetin listten farkı ise DbSet sql tarafında bir tablo oluşturur. List ise sql tarafında bir tablo oluşturmaz.
        //list sadece c# tarafında bir koleksiyon oluşturur. DbSet ise sql tarafında bir tablo oluşturur. O yüzden DbSet kullanırız.

        public DbSet<Product> Products { get; set; }
        //referans sayesinde tablolara erişiyoruz. Yani Category tablosuna erişmek istediğimizde Categories üzerinden erişiyoruz. Product tablosuna erişmek istediğimizde Products üzerinden erişiyoruz.

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public int MyProperty { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
