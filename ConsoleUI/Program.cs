using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByUnitsInStock(5))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}