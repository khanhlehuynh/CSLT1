public class Cat
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }

    public Cat(string name, string color, int age)
    {
        Name = name;
        Color = color;
        Age = age;
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}, Age: {Age}");
    }
}