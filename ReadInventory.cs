using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement1
{
    public class ReadInventory
    {
        public InventoryDetails Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();      ///read file and store in json///

                    return JsonConvert.DeserializeObject<InventoryDetails>(json); ////convert stream of bytes in object///
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}