using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace InventoryMangement
{
    public class ReadInventory
    {
        public InventoryDetails Read(string path)
        {
            try 
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
