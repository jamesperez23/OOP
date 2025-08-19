try
{
    string name = "Johnson";
    int DateTime = 7;

    if (DateTime < 12)
    {
        Console.WriteLine($"Good morning {name}");
        Console.WriteLine($"The current time is {DateTime}");
    }

    else if (DateTime == 12)
    {
        Console.WriteLine($"Good afternoon {name}");
        Console.WriteLine($"The current time is {DateTime}");
    }

    else
    {
        Console.WriteLine($"Good evening {name}");
        Console.WriteLine($"The current time is {DateTime}");
    }
}
catch (Exception)
{
    Console.WriteLine("error");
}
