using FilterApp;


class Program
{
    public static void Main(string[] args)
    {
        // instantiate Orders
        Orders orders = new Orders();

        // define bool for loop 
        bool exit = false;

        // start loop 
        do
        {
            // prompt user to choose either method syntax or query syntax, or exit the program
            Console.WriteLine("Please choose beetween Method Syntax (type 1) and Query Syntax (type 2) or exit the program by pressing any key");
            string choice = Console.ReadLine();

            // if user chose method syntax
            if (choice == "1")
            {
                // prompt user to choose query 
                string input = UserInput.TakeInput();
                
                // execute query 
                string result = Queries.ExecuteQuery(input);

                // output result
                Console.WriteLine(result);
            }
            
            // if user chose query syntax
            else if (choice == "2")
            {
                // prompt user to choose query 
                string input = UserInput.TakeInput();

                // execute query 
                string result = Queries.ExecuteSQLQuery(input);

                // output result
                Console.WriteLine(result);
            }

            // if user chose to exit the program
            else
            {
                // set exit condition for loop to true
                exit = true;
            }
            
        } while (!exit); // continue to loop until exit is set to true
    }
}

