using System;
using System.Collections.Generic;

class Website
{
    public string name, path, description, ip;

    public void Input()
    {
        name = Console.ReadLine();
        path = Console.ReadLine();
        description = Console.ReadLine();
        ip = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine(name + " " + path + " " + description + " " + ip);
    }
}

class Magazine
{
    public string name, description, phone, email;
    public int year;

    public void Input()
    {
        name = Console.ReadLine();
        year = Convert.ToInt32(Console.ReadLine());
        description = Console.ReadLine();
        phone = Console.ReadLine();
        email = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine(name + " " + year + " " + description + " " + phone + " " + email);
    }
}

class Shop
{
    public string name, address, description, phone, email;

    public void Input()
    {
        name = Console.ReadLine();
        address = Console.ReadLine();
        description = Console.ReadLine();
        phone = Console.ReadLine();
        email = Console.ReadLine();
    }

    public void Print()
    {
        Console.WriteLine(name + " " + address + " " + description + " " + phone + " " + email);
    }
}

class Reservoir
{
    double volume, current;
    string material;

    public Reservoir(double v)
    {
        volume = v;
        current = 0;
        material = "";
    }

    public Reservoir(double v, string m)
    {
        volume = v;
        material = m;
        current = 0;
    }

    public Reservoir(double v, string m, bool filled)
    {
        volume = v;
        material = m;
        current = filled ? v : 0;
    }

    public void Fill(double x)
    {
        if (current + x <= volume)
            current += x;
        else
            Console.WriteLine("Overflow");
    }

    public void Empty()
    {
        current = 0;
    }
}

class Program
{
    static void Main()
    {
        int n = 5;
        char symbol = '*';

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(symbol);
            Console.WriteLine();
        }

        int number = 1221;
        string s = number.ToString();
        bool palindrome = true;

        for (int i = 0; i < s.Length / 2; i++)
            if (s[i] != s[s.Length - 1 - i])
                palindrome = false;

        Console.WriteLine(palindrome);

        int[] a = { 1, 2, 6, -1, 88, 7, 6 };
        int[] b = { 6, 88, 7 };

        List<int> result = new List<int>();

        foreach (int x in a)
            if (!Array.Exists(b, y => y == x))
                result.Add(x);

        foreach (int x in result)
            Console.Write(x + " ");

        Console.WriteLine();

        Website site = new Website();
        site.Input();
        site.Print();

        Magazine magazine = new Magazine();
        magazine.Input();
        magazine.Print();

        Shop shop = new Shop();
        shop.Input();
        shop.Print();

        Reservoir r = new Reservoir(100, "Metal", false);
        r.Fill(50);
        r.Empty();
    }
}