public class Menu
{
    private string _name;
    public string Name
    {
        get{return _name;}
        set{_name = value;}
    }
    private int _mouse;
    private int _keyboard;
    private int _phone;
    private int _total;
    public  int TotalPrice
    {
        get{return _total;}
        set{_total = value;}
        
    }

    public Menu()
    {
        _name = "Clari";
        _mouse = 10;
        _keyboard = 20;
        _phone = 50;
    }

    //this method will greet the user
    public void GreetMethod()
    {
        Console.Clear();
        Console.WriteLine("Hello " + _name + ", what can I do for you?");
        Console.WriteLine("1. Choose an item");
        Console.WriteLine("2. Checkout");
    }

    public void BuyItem()
    {
        Console.WriteLine("1. Mouse $" + _mouse);
        Console.WriteLine("2. Keyboard $" + _keyboard);
        Console.WriteLine("3. Phone $" + _phone);
        string answer = Console.ReadLine();
        if(answer == "1")
        {
            Console.WriteLine("Mouse  $10");
            _total += _mouse;
        }
        else if (answer == "2")
        {
            Console.WriteLine("Keyboard $20");
            _total += _keyboard;
        }
        else if(answer == "3")
        {
            Console.WriteLine("Phone $50");
            _total += _phone;
        }
    }
}