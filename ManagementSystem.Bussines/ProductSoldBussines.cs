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
    public class ProductSoldBussines
    {
        public static List<ProductSold> LoadProductSold()
        {
            return ProductSoldData.LoadProductSold();
        }

        public static void CreateProductSold(ProductSold productSold)
        {
            ProductSoldData.CreateProductSold(productSold);
        }

        public static void UpdateProductSold(ProductSold productSold)
        {
            ProductSoldData.UpdateProductSold(productSold);
        }

        public static void DeleteProductSold(ProductSold productSold)
        {
            ProductSoldData.DeleteProductSold(productSold);
        }
    }
}
