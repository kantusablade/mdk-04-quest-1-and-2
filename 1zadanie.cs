using System;
using UnityEngine; 
class Phone
{
    private string numberModel;
    private double weight;
    private string phoneNumber;

    public Phone(string numberModel, double weight, string phoneNumber)
    {
        this.numberModel = numberModel;
        this.weight = weight;
        this.phoneNumber = phoneNumber;
    }

    public Phone() : this("Ноунейм", 0.0, "Unknown") { }

    public void receiveCall(string name)
    {
        Console.WriteLine("Звонит " + name);
    }

    public void receiveCall(string name, string number)
    {
        Console.WriteLine("Звонит " + name + " Номер: " + number);
    }

    public string getNumber()
    {
        return phoneNumber;
    }

    public void SendMessage(params string[] numbers)
    {
        Console.Write("Сообщение отправлено на номер: ");
        foreach (string number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Phone phone1 = new Phone("Model 1", 0.5, "228");
        Phone phone2 = new Phone("Model 2", 0.7, "666");
        Phone phone3 = new Phone("Model 3", 0.9, "880053535");

        phone1.receiveCall("yara");
        Console.WriteLine("Number: " + phone1.getNumber());

        phone2.receiveCall("yana", "222");
        Console.WriteLine("Number: " + phone2.getNumber());

        phone3.receiveCall("zxcchudila");
        Console.WriteLine("Number: " + phone3.getNumber());

        phone1.SendMessage("444", "555", "666");
    }
}
