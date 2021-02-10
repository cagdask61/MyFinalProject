using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetail();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / "+product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            foreach (var product in productManager.GetProductDetail().Data)
            {
                Console.WriteLine(product.ProductName+" / " + product.CategoryName);
            }

        }

       
        
    }
}
