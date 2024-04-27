Console.WriteLine("Name yo doge:");
string myDogName = Console.ReadLine();
Dog myDOg = new Dog(myDogName);

Dog neighboursDog = new Dog("Cat");


Console.WriteLine($"My dog's name is {myDOg.Name}.");
Console.WriteLine($"My neighbour's dog's name is {neighboursDog.Name}.");

myDOg.Rename("Not-Dog");

while (myDOg.LevelOfHappiness != 5)
{
    myDOg.Bark();
}

myDOg.WagTail(); 


class Dog
{
    private string _name;
    private int _levelOfHappiness;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; } 
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog's been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Bork-Bork ");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("wiglwigl");
    }


} 
