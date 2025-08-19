try
{
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter the (HH:mm format, e.g., 14:00): ");
    string timeInput = Console.ReadLine();

    TimeSpan time = TimeSpan.Parse(timeInput);

    if (time < new TimeSpan(12, 0, 0)) // Before noon
    {
        Console.WriteLine($"Good morning {name}");
    }
    else if (time < new TimeSpan(18, 0, 0)) // Before 6 PM
    {
        Console.WriteLine($"Good afternoon {name}");
    }
    else // 6 PM and later
    {
        Console.WriteLine($"Good evening {name}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid time format. Please use HH:mm (e.g., 9:45 or 14:00)");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
