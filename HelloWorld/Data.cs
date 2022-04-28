public class Data
{
    private string _guestName;
    public string Name
    {
        get {return _guestName;}
        set {_guestName = value;}
    }
    private int _mousePrice;
    private int _keyboardPrice;
    private int _phonePrice;

    public Data()
    {
        _keyboardPrice = 20;
        _phonePrice = 50;
        _mousePrice = 10;
    }

    List<int> _itemList = new List<int>();
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
        Console.WriteLine("3. Checkout");
    }

    public void AddItem()
    {
        Console.WriteLine("1. Mouse $" + _mousePrice);
        Console.WriteLine("2. Keyboard $" + _keyboardPrice);
        Console.WriteLine("3. Phone $" + _phonePrice);
        string answer = Console.ReadLine();
        if(answer == "1")
        {
            Console.WriteLine("Mouse $" + _mousePrice);

            _itemList.Add(_mousePrice);
        } 
        else if (answer == "2")
        {
            Console.WriteLine("Keyboard $" + _keyboardPrice);
            _itemList.Add(_keyboardPrice);
        }
        else if(answer == "3")
        {
            Console.WriteLine("Phone $" + _phonePrice);
            _itemList.Add(_phonePrice);
            
        }
    }
    
}