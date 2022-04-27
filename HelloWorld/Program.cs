// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

//[class name] [name of object] = new [class name];
// Car obj1 = new Car();
// Console.WriteLine(obj1.Color);

// Car obj2 = new Car("black");
// Console.WriteLine(obj2.Color);

Car obj3 = new Car();

//referencing class members within object

int mile = obj3.TotalDistancePerFuel();

obj3.Sum(5, 10);

Console.WriteLine(mile);

Console.WriteLine("End of Method");

string owner = "Clari";

Car obj4 = new Car(owner);
Console.WriteLine(obj4.Owner);
obj4.Owner = "Daniel";
Console.WriteLine(obj4.Owner);

obj4.Fuel = -100;
Console.WriteLine(obj4.Fuel);

bool repeat = true;
Menu menuobj = new Menu();

Console.WriteLine("Enter name: ");
menuobj.Name = Console.ReadLine();

while(repeat)
{
    menuobj.GreetMethod();
    string answer = Console.ReadLine();
    if (answer == "1")
    {
            menuobj.BuyItem();
    }
    else if(answer =="2")
    {
        Console.WriteLine("Your total is $" +  menuobj.TotalPrice);
        repeat = false;
    }
}