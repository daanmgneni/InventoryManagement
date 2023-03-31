namespace InventoryMangement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Dhanashree\\source\\repos\\InventoryManagementSystem\\Inventory.json";
            ReadInventory obj = new ReadInventory();
            InventoryDetails data = obj.Read(path);

            Console.WriteLine("Type of Rice");
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price);
                int val = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine("The price of {0} for {1} kg is {2}Rs", data.typeOfRice[i].name, data.typeOfRice[i].weight,val);

                Console.Write(" ------------------------------");
            }

            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            Console.WriteLine("Type of Wheat");
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            for (int i = 0; i < data.typeOfWheat.Count; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.WriteLine(data.typeOfWheat[i].name);
                Console.WriteLine(data.typeOfWheat[i].weight);
                Console.WriteLine(data.typeOfWheat[i].price);
                int val = data.typeOfWheat[i].weight * data.typeOfWheat[i].price;
                Console.WriteLine("The price of {0} for {1} kg is {2}Rs", data.typeOfWheat[i].name, data.typeOfWheat[i].weight, val);
                Console.WriteLine(" ------------------------------");
            }

            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            Console.WriteLine("Type of Pulses");
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");
            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.WriteLine(data.typeOfPulses[i].name);
                Console.WriteLine(data.typeOfPulses[i].weight);
                Console.WriteLine(data.typeOfPulses[i].price);
                int val = data.typeOfPulses[i].weight * data.typeOfPulses[i].price;
                Console.WriteLine("The price of {0} for {1} kg is {2}Rs", data.typeOfPulses[i].name, data.typeOfPulses[i].weight, val);
                Console.WriteLine(" ------------------------------");
            }

        }
    }
}