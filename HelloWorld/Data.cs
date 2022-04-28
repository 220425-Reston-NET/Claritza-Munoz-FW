public class Data
{
    private string _guestName;
    public string Name
    {
        get {return _guestName;}
        set {_guestName = value;}
    }
    private string _mouse;
    private string _keyboard;
    private string _phone;
    private int _mousePrice;
    private int _keyboardPrice;
    private int _phonePrice;

    public Data()
    {
        _keyboardPrice = 20;
        _phonePrice = 50;
        _mousePrice = 10;

        _mouse = "Mouse";
        _keyboard = "Keyboard";
        _phone = "Phone";
    }

    List<int> _itemList = new List<int>();
    List<string> _itemList2 = new List<string>();
    public int Total()
    {
        int total = 0;

        foreach(int element in _itemList)
            {
                total += element;
            }
            return total;
    }

    public void greetingMethod()
    {
        Console.WriteLine("Welcome! Please make a selection: ");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Remove Item");
        Console.WriteLine("3. View Items in cart");    
        Console.WriteLine("4. Checkout");
    }

    public void ViewItems()
    {
        Console.WriteLine("These are the items in your cart: ");
        foreach(string element in _itemList2)
        {
            Console.WriteLine(element);
        }
    }

    public void AddItem()
    {
        Console.WriteLine("Add Item");
        Console.WriteLine("1. Mouse $" + _mousePrice);
        Console.WriteLine("2. Keyboard $" + _keyboardPrice);
        Console.WriteLine("3. Phone $" + _phonePrice);
        string answer = Console.ReadLine();
        if(answer == "1")
        {
            Console.WriteLine("Mouse $" + _mousePrice);
            _itemList2.Add(_mouse);
            _itemList.Add(_mousePrice);
        } 
        else if (answer == "2")
        {
            Console.WriteLine("Keyboard $" + _keyboardPrice);
            _itemList2.Add(_keyboard);
            _itemList.Add(_keyboardPrice);
        }
        else if(answer == "3")
        {
            Console.WriteLine("Phone $" + _phonePrice);
            _itemList2.Remove(_phone);
            _itemList.Add(_phonePrice);
        }
    }

    public void RemoveItem()
    {
        Console.WriteLine("Remove Item");
        Console.WriteLine("1. Mouse $" + _mousePrice);
        Console.WriteLine("2. Keyboard $" + _keyboardPrice);
        Console.WriteLine("3. Phone $" + _phonePrice);
        string answer = Console.ReadLine();
         if(answer == "1")
        {
            Console.WriteLine("Mouse $" + _mousePrice);
            _itemList2.Remove(_mouse);
            _itemList.Remove(_mousePrice);
        } 
        else if (answer == "2")
        {
            Console.WriteLine("Keyboard $" + _keyboardPrice);
            _itemList2.Remove(_keyboard);
            _itemList.Remove(_keyboardPrice);
        }
        else if(answer == "3")
        {
            Console.WriteLine("Phone $" + _phonePrice);
            _itemList2.Remove(_phone);
            _itemList.Remove(_phonePrice);
        }
    }
    
}