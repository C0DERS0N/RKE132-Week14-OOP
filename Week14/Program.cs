Console.WriteLine("Your dog name:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good Girl!");

Console.WriteLine($"My dog name is {myDog.Name}.");
Console.WriteLine($"My neighbour dog name is  {neighboursDog.Name}.");


myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}


myDog.WagTail();

class Dog   
{
    //fields
    private string _name;
    private int _levelOfHapiness;


    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int PrecentOfHappiness
    {
        get { return _levelOfHapiness; }
    }



    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wigle-wigle!");
    }

}