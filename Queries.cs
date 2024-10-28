using System.Text;

namespace FilterApp
{
    internal class Queries
    {
       // method for executing method queries
        public static string ExecuteQuery(string input)
        {
            // create string builder to hold results
            StringBuilder sb = new StringBuilder();

            // switch statement for queries
            switch (input)

            {
                case "1":
                    string city = string.Empty;
                    try
                    {
                        Console.WriteLine("input city to query customers:");
                        city = Console.ReadLine();
                    }
                    catch (Exception ex) { Console.WriteLine($"Error {ex.Message}"); }

                    var query1 = Order.OrderList.Where(order => order.City == city);                    
                    foreach (var order in query1)
                    {
                        sb.Append($"Customer name: {order.Name}.\n");
                    }
                    break;
                case "2":
                    var query2 = Order.OrderList.Where(order => order.Age < 30);
                    foreach (var order in query2)
                    {
                        sb.Append($"Customer name: {order.Name}, Customer Age: {order.Age}.\n");
                    }
                    break;
                case "3":
                    var query3 = Order.OrderList.Where(order => order.OrderValue > 100);
                    foreach (var order in query3)
                    {
                         sb.Append($"Customer name: {order.Name}, Order value {order.OrderValue}.\n");
                    }
                    break;
                case "4":
                    var query4 = Order.OrderList.Where(order => order.ProductionCategory == "Electronic");
                    foreach (var order in query4)
                    {
                        sb.Append($"customer name: {order.Name}.\n");
                    }
                    break;
                case "5":
                    DateTime date = new DateTime(2023, 1, 1);
                    var query5 = Order.OrderList.Where(order => DateTime.Compare(order.OrderDate, date) == 1);
                    foreach (var order in query5)
                    {
                        sb.Append($"customer name: {order.Name}, order date: {order.OrderDate.ToString("MM/dd/yyyy")}.\n");
                    }
                    break;
                case "6":   
                    var query6 = Order.OrderList.OrderBy(order => order.Name);
                    foreach (var order in query6)
                    {
                        sb.Append($"customer name: {order.Name}.\n");
                    }
                    break;
                case "7":
                    city = string.Empty;
                    try
                    {
                        Console.WriteLine("input city to query customers:");
                        city = Console.ReadLine();
                    }
                    catch (Exception ex) { Console.WriteLine($"Error {ex.Message}"); }

                    var query7 = Order.OrderList.GroupBy(order => order.City).Where(group => group.Key == city).SelectMany(group => group);
                    foreach (var order in query7)
                        
                        sb.Append($"customer name: {order.Name}.\n");
                    break;
                case "8":
                    var query8 = Order.OrderList.OrderByDescending(order => order.Age).Take(3);
                    foreach (var order in query8)
                    {
                        sb.Append($"customer name: {order.Name}, customer age: {order.Age}. \n");
                    }
                    break;
                default:
                    break;
            }
            // if string builder length is greater than zero format string builder to string and return it, else return no match found
            return sb.Length > 0 ? sb.ToString() : "No match found.";
        }

        // method for executing query syntax
        public static string ExecuteSQLQuery(string input)
        {
            // create string builder to hold results
            StringBuilder sb = new StringBuilder();

            switch(input)
            {
                // switch statment for queries
                case "1":
                    string city = string.Empty;
                    try
                    {
                        Console.WriteLine("input city to query customers:");
                        city = Console.ReadLine();
                    } catch (Exception ex) { Console.WriteLine($"Error {ex.Message}"); }
                   
                    var query1 = from order in Order.OrderList where order.City == city select order;
                    foreach (var order in query1)
                    {
                        sb.Append($"Customer name: {order.Name}.\n");
                    }
                    break;
                case "2":
                    var query2 = from order in Order.OrderList where order.Age < 30 select order; 
                    foreach (var order in query2)
                    {
                        sb.Append($"Customer name: {order.Name}, Customer Age: {order.Age}.\n");
                    }
                    break;
                case "3":
                    var query3 = from order in Order.OrderList where order.OrderValue > 100 select order; 
                    foreach (var order in query3)
                    {
                        sb.Append($"Customer name: {order.Name}, Order value {order.OrderValue}.\n");
                    }
                    break;
                case "4":
                    var query4 = from order in Order.OrderList where order.ProductionCategory == "Electronic" select order;
                    foreach (var order in query4)
                    {
                        sb.Append($"customer name: {order.Name}.\n");
                    }
                    break;
                case "5":
                    DateTime date = new DateTime(2023, 1, 1);
                    var query5 = from order in Order.OrderList where DateTime.Compare(order.OrderDate, date) == 1 select order;
                    foreach (var order in query5)
                    {
                        sb.Append($"customer name: {order.Name}, order date: {order.OrderDate.ToString("MM/dd/yyyy")}.\n");
                    }
                    break;
                case "6":
                    var query6 = from order in Order.OrderList orderby order.Name select order;
                    foreach (var order in query6)
                    {
                        sb.Append($"customer name: {order.Name}.\n");
                    }
                    break;
                case "7":
                    city = string.Empty;
                    try
                    {
                        Console.WriteLine("input city to query customers:");
                        city = Console.ReadLine();
                    }
                    catch (Exception ex) { Console.WriteLine($"Error {ex.Message}"); }

                    var query7 = from order in Order.OrderList group order by order.City into cityGroup where cityGroup.Key == city from order in cityGroup select order;  
                    foreach (var order in query7)

                        sb.Append($"customer name: {order.Name}.\n");
                    break;
                case "8":
                    var query8 = (from order in Order.OrderList orderby order.Age descending select order).Take(3);   
                    foreach (var order in query8)
                    {
                        sb.Append($"customer name: {order.Name}, customer age: {order.Age}. \n");
                    }
                    break;
                default:
                    break;
                }

                // if string builder length is greater than zero format string builder to string and return it, else return no match found
                return sb.Length > 0 ? sb.ToString() : "No match found.";
            
            }
    }
}
