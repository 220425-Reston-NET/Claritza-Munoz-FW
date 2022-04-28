using System.Collections;

public class Collections
{
    //array
    //used to store a datatype and have fixed sizes
    //syntax: datatype[] nameOfVariable = new (datatype)[sizeOfArray]
    int[] _numbersArray = new int[5];
    
    //generic collections
    //they are a collection that store specific datatypes
    //dynamically changing size

    //List collection
    //zero-based index
    //used to store datatype & dynamically changing size
    List<int> _numbersList = new List<int>();

    //hashset collection
    //there is no particular order to the elements
    //not zero-based (cant get specific elements or LINQ)
    //cannot have duplicated elements; everything must be new
    HashSet<int> _numbersHash = new HashSet<int>();

    //dictionary collection
    //store information through key-value pairs
    //there is no particular order
    //you can specify what datatype you want both key and value to be 
    //key needs to be unique to locate info
    Dictionary<string, int> _personAge = new Dictionary<string, int>();

    //non-generic collection
    //doesn't need datatype

    //ArrayList collection
    ArrayList _numbersArrayList = new ArrayList();

    public void CollectionMain()
    {
        Console.WriteLine("===Array Demo===");
        //Allows us to set what to store in certain positions
        //0 1 2 3 4 - zero-based index
        _numbersArray[0] = 3;
        _numbersArray[1] = 10;
        _numbersArray[2] = 100;

        //a way to go through array
        foreach(int element in _numbersArray)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("===List Demo ===");
        _numbersList.Add(3);
        _numbersList.Add(10);
        _numbersList.Add(100);

        Console.WriteLine(_numbersList[1]);

        foreach(int element in _numbersList)
        {
            Console.WriteLine(element);
        }

        //for  loop

        for(int i = 0; i < _numbersList.Count; i++)
        {
            Console.WriteLine(_numbersList[i]);
        }

        int i2 = 0;
        while(i2 < _numbersList.Count)
        {
            Console.WriteLine(_numbersList[i2]);
            i2++;
        }

        Console.WriteLine("===Hash Demo===");
        _numbersHash.Add(3);
        _numbersHash.Add(10);
        _numbersHash.Add(100);
        _numbersHash.Add(100);

        foreach(int element in _numbersHash)
        {
            Console.WriteLine(element);
        }
        
        Console.WriteLine("===Dictionary Demo===");
        _personAge.Add("Chadel", 26);
        _personAge.Add("Troy", 31);
        _personAge.Add("Maaz", 24);

        Console.WriteLine(_personAge["Troy"]);

        Console.WriteLine("===ArrayList Demo===");
        _numbersArrayList.Add("Hello");
        _numbersArrayList.Add(10);
        _numbersArrayList.Add(12.03);
        _numbersArrayList.Add(true);

        foreach(object item in _numbersArrayList)
        {
            Console.WriteLine(item);
        }
    }

}