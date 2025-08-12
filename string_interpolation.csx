//String Interpolation
try
{
    string name = "PJ Mathew A. Perez";
    int age = 19;
    string address = "117 Magsaysay St. , New Cabalan, Olongapo City Zambales";

    // Basic string interpolation
    Console.WriteLine($"Hello, my name is {name}.");

    // Interpolating multiple variables
    Console.WriteLine($"I am {age} years old and I live in {address}.");

    // Using expressions in interpolation
    Console.WriteLine($"Next year, I will be {age + 1} years old.");

    // Formatting numbers
    double price = 199.99;
    Console.WriteLine($"The price is {price:F2}.");

    // Date formatting
    DateTime today = DateTime.Now;
    Console.WriteLine($"Today is {today:dddd, MMMM dd yyyy}.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}






