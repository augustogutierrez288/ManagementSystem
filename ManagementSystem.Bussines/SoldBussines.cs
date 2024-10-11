using ManagementSystem.Data;
using ManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Bussines
{
    public class SoldBussines
    {
        public static List<Sold> LoadSold()
        {
            return SoldData.LoadSold();
        }

        public static void CreateSold(Sold sold)
        {
            SoldData.CreateSold(sold);
        }

        public static void UpdateSold(Sold sold)
        {
            SoldData.UpdateSold(sold);

        }

        public static void DeleteSold(Sold sold)
        {
            SoldData.DeleteSold(sold);

        }
    }
}
