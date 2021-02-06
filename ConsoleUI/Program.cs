using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GettAll())
            {
                Console.WriteLine("Ürünün Adı: " + category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("--------------------------------");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("--------------------------------");
            foreach (var product in productManager.GetByUnitPrice(50, 6000))
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("--------------------------------");
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
