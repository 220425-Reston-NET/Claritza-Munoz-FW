//Creating a class using class  keyword
//public makes class available to everyone
//by default fields should all be private
public class Car
{
    //this is a field
    //used to  store info or to define current state of object
    private string _color;
    private string _owner;

    private int _fuel;
    private int _gallonPerMile;

    //method 
    //represent behavior/function 
    //will run multiple lines of code
    //void means method will not return anything
    //any other datatype, method will expect to return that datatype
    public int TotalDistancePerFuel()
    {
        Console.WriteLine("Current Fuel: " + _fuel + " This is the owner: " + _owner);
        Console.WriteLine($"Current Gallon per Mile: {_gallonPerMile} This is the owner: {_owner}");

        Console.WriteLine("This is how many miles: " + _fuel/_gallonPerMile);

        //return keyword is what the method will give back
        return _fuel/_gallonPerMile;
    }

    //methods can also have parameters
    //parameters implemented by adding datatypes inside the parenthesis
    //comma if more than one parameter
    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1+num2);
    }
    
    //this is a constructor
    //special method will run when object is created
    public Car()
    {
        _color = "Blue";
        _fuel = 100;
        _gallonPerMile = 5;
        _owner = "Claritza";
    }

    public Car(string p_owner)
    {
        _owner = p_owner;
    }

    //This is a property
    //gives flexibility to check that data being stored is correct
    //only certain things can access data
    //make things read only/ write only
    public string Owner
    {
        //get keyword
        //how data  will be shared
        get {return _owner + " is the owner of this car.";}
        
        //set keyword
        //how data will be changed
        set {_owner = value+" Owner";}
    }

    //fuel can only hold numbers from 0 - 100
    public int Fuel
    {
        get {return _fuel;}
        set 
        {
            if(value >= 0 && value <= 100)
            {
               _fuel = value; 
            }
            else 
            {
                _fuel = 100;
                Console.WriteLine("Fuel can only hold from 0 - 100");
            }
        }
    }

    //constructor
    //method will execute when object is created
    // public Car()
    // {
    //     Console.WriteLine("Making  a car object!");
    // }
    // public Car(string p_color)
    // {
    //     Console.WriteLine("Making  a car object!");
    //     _color = p_color;
    // }

    // //this is a property
    // //control how data is being saved and obtained
    // public string Color
    // {
    //     //grab info
    //     get { return _color + " is the color of the car";}
    //     //save info
    //     set { _color = value;}
    // }
}