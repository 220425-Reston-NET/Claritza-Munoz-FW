public class Conversions
{
    //statis keyword will make whatever class member belongs to the class itself
    //we dont have to create an object out of class to use it

    public static void conversionsMain()
    {
        //general coding terms
        //implicit - something is done automatically (usually compiler)
        //Explicit - you have to write some syntax to tell the compiler to do something

        Console.WriteLine("===Conversion Demo ===");
        int number = 10;
        double numberDecimal = 76.3;
        string word = "Hello";

        //implicit conversion
        //complier will automatically convert one datatype  to another with you needing to specify anything
        //if you are going from one datatype to another datatype without loosing info it is implicit conversion
        Console.WriteLine("=Implicit");

        //double  datatype can set its value using an int datatype
        numberDecimal = number;
        Console.WriteLine(numberDecimal);

        //explicit conversion
        //write syntax to tell compiler to do conversion with the potential possibility of losing data
        Console.WriteLine("=Explicit=");
        numberDecimal = 76.5462;
        //syntax: (datatype)variableName
        number = (int)numberDecimal;
        Console.WriteLine(number);

        //more explicit conversion
        string numberString = number.ToString();
        Console.WriteLine(numberString);

        //Converting string into numerical values
        string doubleString = "438.1434";
        double double2 = Convert.ToDouble(doubleString);
        Console.WriteLine(double2/2);
    }
}