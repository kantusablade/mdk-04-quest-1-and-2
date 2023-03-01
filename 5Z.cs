interface Printable
{
    void Print();
}

class Book : Printable
{
    public void Print()
    {
        Console.WriteLine("Printing a book...");
    }

    public static void printBooks(Printable[] printables)
    {
        foreach (Printable printable in printables)
        {
            if (printable is Book)
            {
                Console.WriteLine("Printing a book only...");
            }
        }
    }
}

class Magazine : Printable
{
    public void Print()
    {
        Console.WriteLine("Printing a magazine...");
    }

    public static void printMagazines(Printable[] printables)
    {
        foreach (Printable printable in printables)
        {
            if (printable is Magazine)
            {
                Console.WriteLine("Printing a magazine only...");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Printable[] printables = new Printable[] { new Book(), new Magazine() };
        foreach (Printable printable in printables)
        {
            printable.Print();
        }
        Book.printBooks(printables);
        Magazine.printMagazines(printables);
    }
}