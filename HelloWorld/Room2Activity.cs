

Items obj1 = new Items();
bool repeat = true;
int total =0;

while (repeat)
{
    Console.WriteLine("1. Enter List");
    Console.WriteLine("2. Exit");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
        while (repeat)
        {
            Console.WriteLine("1. Bread");
            Console.WriteLine("2. Cheese");
            Console.WriteLine("3. Milk");
            Console.WriteLine("4. Sugar");
            Console.WriteLine("5. Salt");
            Console.WriteLine("6. Checkout");
            string answer2 = Console.ReadLine();

            if(answer2 == "1")
            {
                Console.WriteLine("Bread: $1");
                total+=obj1.Bread;
            }
            else if(answer2 == "2")
            {
                Console.WriteLine("Cheese: $4");
                total+=obj1.Cheese;
            }
            else if(answer2 == "3")
            {
                Console.WriteLine("Milk: $3");
                total+=obj1.Milk;
            }
            else if(answer2 == "4")
            {
                Console.WriteLine("Sugar: $2");
                total+=obj1.Sugar;
            }
            else if(answer2 == "5")
            {
                Console.WriteLine("Salt: $2");
                total+=obj1.Salt;
            }
            else if(answer2 == "6")
            {
                Console.WriteLine("Your total is: $" + total);
                repeat = false;
            }
            else
            {
                Console.WriteLine("Error: Choose valid option.");
            }

        }
    }
    else if (answer == "2")
    {
        repeat = false;
    }
    else
    {
        Console.WriteLine("Error: Choose valid option.");
    }
}
public class Items
{
    private int _bread = 1;
    private int _cheese = 4;
    private int _milk  = 3;
    private int _sugar = 2;
    private int _salt = 2;

    public int Bread
    {
        get {return _bread;}
    }
    public int Cheese
    {
        get {return _cheese;}
    }
    public int Milk
    {
        get {return _milk;}
    }
    public int Sugar
    {
        get {return _sugar;}
    }
    public int Salt
    {
        get {return _salt;}
    }
}
