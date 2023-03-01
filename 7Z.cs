using System;

class Person
{
    public string fullName { get; set; }
    public int age { get; set; }

    public Person()
    {
        fullName = "Unknown";
        age = 0;
    }

    public Person(string fullName, int age)
    {
        this.fullName = fullName;
        this.age = age;
    }

    public void move()
    {
        Console.WriteLine(fullName + " is moving");
    }

    public void talk()
    {
        Console.WriteLine(fullName + " is talking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person("John Doe", 30);

        person1.move();
        person1.talk();

        person2.move();
        person2.talk();

        Console.ReadLine();
    }
}