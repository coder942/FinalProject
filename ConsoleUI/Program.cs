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

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("Ürün Adı: " + product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("--------------------------------");
            foreach (var product in productManager.GetAllByCategoryId(2).Data)
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("--------------------------------");
            foreach (var product in productManager.GetByUnitPrice(50, 6000).Data)
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName);
            }
            Console.WriteLine("--------------------------------");
        }
    }
}
