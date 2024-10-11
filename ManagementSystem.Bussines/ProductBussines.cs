using ManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementSystem.Entities;
using ManagementSystem.Data;

namespace ManagementSystem.Bussines
{
    public class ProductBussines
    {
        public static List<Product> LoadProduct()
        {
            return ProductData.LoadProduct();
        }
        public static void CreateProduct(Product product)
        {
            ProductData.CreateProduct(product);
        }
        public static void UpdateProduct(Product product)
        {
            ProductData.UpdateProduct(product);
        }
        public static void DeleteProduct(Product product)
        {
            ProductData.DeleteProduct(product);

        }
    }
}
