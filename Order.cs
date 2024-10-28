namespace FilterApp
{
    internal class Order
    {
       

        // getter and setter
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string ProductionCategory { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderValue { get; set; }


        // instance List

        public static List<Order> OrderList = new List<Order>();

        // constructor
        public Order(string name,  int age, string city, string productionCategory, DateTime orderDate, decimal orderValue)
        {
            Name = name;
            Age = age;
            City = city;
            ProductionCategory = productionCategory;
            OrderDate = orderDate;
            OrderValue = orderValue;

            // add new Orders to the instance List
            OrderList.Add(this);
        }
    }
}
