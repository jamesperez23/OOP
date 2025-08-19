try
{
    int a = 20;
    int b = 10;
    
    if (a > b)
    {
        Console.WriteLine($"{a} is greater than {b}");
    }
    else
    {
        Console.WriteLine("CANNOT BE!!");
    }
}
catch (Exception)
{
    Console.WriteLine("error");
}
