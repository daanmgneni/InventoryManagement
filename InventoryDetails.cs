using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement1
{
    public class InventoryDetails
    {
        public List<Stock1> stock1;
        public List<Stock2> stock2;

        public List<Stock3> stock3;

    }

    public class Stock1
    {
        public string shareName;
        public int NumberShares;
        public int price;

    }

    public class Stock2
    {
        public string shareName;
        public int NumberShares;
        public int price;

    }

    public class Stock3
    {
        public string shareName;
        public int NumberShares;
        public int price;

    }
}