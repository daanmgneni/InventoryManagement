using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangement
{
    public class InventoryDetails
    {
        public List< TypeOfRice> typeOfRice;
        public List<TypeOfWheat> typeOfWheat;
        public List<TypeOfPulses> typeOfPulses;
    }

    public class TypeOfRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
}
