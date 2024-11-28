using System.Linq;

namespace CastielloLorenzoCoolshopTest
{
    internal class Program
    {
        /**
         * Get the csv file path by the user
         */
        public static string? getFile()
        {
            Console.Write("File path (add a .csv file) -> ");
            return Console.ReadLine();
        }

        /**
         * Validate the file passed as a parameter
         */
        public static bool validateFile(string file)
        {
            if (file != null)
            {
                // check if file name ends with .csv (has csv extension)
                if (!file.EndsWith(".csv"))
                {
                    return false;
                }
                // check if the file exists
                if (!File.Exists(file))
                {
                    return false;
                }

                // read all lines
                var lines = File.ReadAllLines(file);

                // check if the file is empty
                if (lines.Length == 0)
                {
                    return false;
                }

                // get the number of columns
                var columnNumber = lines[0].Split(',').Length;

                // loop through each line
                foreach (var line in lines)
                {
                    // check if every line has the same number of columns
                    if (line.Split(',').Length != columnNumber)
                    {
                        return false;
                    }
                }
                // if the file is valid
                return true;
            }
            // if the file is not valid
            return false;
        }

        /**
         * Popolate a list of orders
         */
        public static void popolateList(List<Order> list, string[] lines)
        {
            // loop through each line (skip the first one)
            foreach (var line in lines.Skip(1))
            {
                // create an order object using the class Order
                var order = new Order();

                // split the line
                string[] data = line.Split(',');

                // configure order object
                order.Id = int.Parse(data.ElementAt(0));
                order.ArticleName = data.ElementAt(1);
                order.Quantity = int.Parse(data.ElementAt(2));
                order.UnitPrice = double.Parse(data.ElementAt(3));
                order.PercentageDiscount = double.Parse(data.ElementAt(4));
                order.Buyer = data.ElementAt(5);

                // add the order to the list
                list.Add(order);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Coolshop Backend Test");

            // get the file path calling the function
            string? filePath = getFile();

            // check if the file is valid
            bool isFileValid = validateFile(filePath);

            // check if the file is valid
            if (isFileValid)
            {
                // store the lines (strings array) into a variable
                string[] lines = File.ReadAllLines(filePath);

                // create a list for the orders
                List<Order> orders = new List<Order>();

                popolateList(orders, lines);

                orders.ForEach(o => Console.WriteLine(o.ToString()));
            }
            else
            {
                Console.WriteLine("The file is not valid");
            }
        }
    }
}
