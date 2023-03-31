

namespace InventoryManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory problems");

            string path = "C:\\Users\\Dhanashree\\source\\repos\\InventoryManagementSystem\\Inventory.json";
            ReadInventory obj = new ReadInventory();

            InventoryDetails data = obj.Read(path);

            Console.WriteLine("Stock 1");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock1.Count; i++)
            {
                Console.WriteLine(data.stock1[i].shareName);
                Console.WriteLine(data.stock1[i].NumberShares);
                Console.WriteLine(data.stock1[i].price);

                int val = data.stock1[i].NumberShares * data.stock1[i].price;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock1[i].shareName, data.stock1[i].shareName, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Stock 2");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock2.Count; i++)
            {
                Console.WriteLine(data.stock2[i].shareName);
                Console.WriteLine(data.stock2[i].NumberShares);
                Console.WriteLine(data.stock2[i].price);

                int val = data.stock2[i].NumberShares * data.stock2[i].price;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock2[i].shareName, data.stock2[i].NumberShares, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Stock 3");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.stock3.Count; i++)
            {
                Console.WriteLine(data.stock3[i].shareName);
                Console.WriteLine(data.stock3[i].NumberShares);
                Console.WriteLine(data.stock3[i].price);

                int val = data.stock3[i].NumberShares * data.stock3[i].price;
                Console.WriteLine("The price of {0} for {1} stock is {2}Rs. ", data.stock3[i].shareName, data.stock3[i].NumberShares, val);
            }

            Console.WriteLine("-------------------------------------");

        }
    }
}