//String Variable
try
{
    string firstName = "Patrick";
    string lastName = "Perez";

    // Concatenation
    string fullName = firstName + " " + lastName;
    Console.WriteLine($"Full Name: {fullName}");

    // String interpolation
    Console.WriteLine($"Hello, {firstName} {lastName}!");

    // Length
    Console.WriteLine($"Length of first name: {firstName.Length}");

    // ToUpper and ToLower
    Console.WriteLine($"Uppercase: {firstName.ToUpper()}");
    Console.WriteLine($"Lowercase: {lastName.ToLower()}");

    // Substring
    Console.WriteLine($"First 2 characters of first name: {firstName.Substring(0, 2)}");

    // Contains
    Console.WriteLine($"Does full name contain 'Patrick'? {fullName.Contains("Patrick")}");

    // Replace
    Console.WriteLine($"Replace 'Patrick' with 'PJM': {fullName.Replace("Patrick", "PJM")}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

