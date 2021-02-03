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
        }
    }
}
