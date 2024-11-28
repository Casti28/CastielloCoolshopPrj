using System.Linq;

namespace CastielloLorenzoCoolshopTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coolshop Backend Test");

            // get the csv file path from the console
            string filePath = Console.ReadLine();

            // stream reader for the file
            StreamReader reader = new StreamReader(filePath);
            // store the file content (string) into a variable
            string fileContent = reader.ReadToEnd();
            // close the stream reader
            reader.Close();

            // create an array that contains the lines in the csv file
            string[] lines = fileContent.Split('\n');

            // create a list for the orders
            List<Order> orders = new List<Order>();

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
                orders.Add(order);
            }

            orders.ForEach(o => Console.WriteLine(o.ToString()));

        }
    }
}
