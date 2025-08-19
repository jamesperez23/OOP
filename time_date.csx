try

{
    Console.WriteLine("Enter a date (MM/dd/yyyy):");
    string Input = Console.ReadLine();

    if (DateTime.TryParse(Input, out DateTime date))
    {
        DayOfWeek dayOfWeek = date.DayOfWeek;
        Console.WriteLine($"You entered a {dayOfWeek}.");

        switch (dayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Start of the work week.");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("End of the work week.");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("It's the weekend!");
                break;
            default:
                Console.WriteLine("Midweek day.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid date format. Please use MM/dd/yyyy.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid date format. Please use MM/dd/yyyy.");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}