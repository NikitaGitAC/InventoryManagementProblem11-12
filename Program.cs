
namespace inventory_problems
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory problems");

            string path = "C:\\Users\\Akshu\\source\\repos\\266\\inventory problems\\inventory problems\\data.json";
            readinventory obj = new readinventory();

            inventorydetails data = obj.Read(path);

            Console.WriteLine("Types of Rices");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);

                int val = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("The price of {0} for {1} is {2}Rs. ", data.typesOfRice[i].name, data.typesOfRice[i].weight, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Types of Wheet");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.typesOfwheet.Count; i++)
            {
                Console.WriteLine(data.typesOfwheet[i].name);
                Console.WriteLine(data.typesOfwheet[i].weight);
                Console.WriteLine(data.typesOfwheet[i].price);

                int val = data.typesOfwheet[i].weight * data.typesOfwheet[i].price;
                Console.WriteLine("The price of {0} for {1} is {2}Rs. ", data.typesOfwheet[i].name, data.typesOfwheet[i].weight, val);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Types of Pulses");

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);

                int val = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
                Console.WriteLine("The price of {0} for {1} is {2}Rs. ", data.typesOfPulses[i].name, data.typesOfPulses[i].weight, val);
            }

            Console.WriteLine("-------------------------------------");

        }
    }



}
    

    

    



            






        
