//Math Class
try
{
    double a = 9.0;
    double b = -3.5;

    // Square root
    Console.WriteLine($"Math.Sqrt({a}) = {Math.Sqrt(a)}");

    // Absolute value
    Console.WriteLine($"Math.Abs({b}) = {Math.Abs(b)}");

    // Power
    Console.WriteLine($"Math.Pow({a}, 2) = {Math.Pow(a, 2)}");

    // Maximum
    Console.WriteLine($"Math.Max({a}, {b}) = {Math.Max(a, b)}");

    // Minimum
    Console.WriteLine($"Math.Min({a}, {b}) = {Math.Min(a, b)}");

    // Round
    Console.WriteLine($"Math.Round(3.14159) = {Math.Round(3.14159)}");

    // Ceiling
    Console.WriteLine($"Math.Ceiling(3.14) = {Math.Ceiling(3.14)}");

    // Floor
    Console.WriteLine($"Math.Floor(3.99) = {Math.Floor(3.99)}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


