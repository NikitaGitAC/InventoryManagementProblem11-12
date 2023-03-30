﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_problems
{
    public class readinventory
    {
        public inventorydetails Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();      ///read file and store in json///

                    return JsonConverter.DeserializeObject<inventorydetails>(json); ////convert stream of bytes in object///
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

