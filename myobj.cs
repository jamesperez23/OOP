using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string PersonName, int PersonAge)
    {
        Name = PersonName;
        Age = PersonAge;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Person person = new Person(name, age);
        person.Introduce();
    }


}
