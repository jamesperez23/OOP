//String Variable
try
{
    string firstName = "Patrick";
    string lastName = "Perez";

    // Concatenation
    Console.WriteLine("\n");
    Console.WriteLine("Concatenation");
    string fullName = firstName + " " + lastName;
    Console.WriteLine($"FullName: {fullName}\n");

    // String interpolation
    Console.WriteLine("String Interpolation");
    Console.WriteLine($"Hello, {firstName} {lastName}|\n");

    // Length
    Console.WriteLine("Length:");
    Console.WriteLine($"Length of first name: {firstName.Length}\n");

    // ToUpper and ToLower
    Console.WriteLine("ToUpper and ToLower:");
    Console.WriteLine($"Uppercase: {firstName.ToUpper()}\n");
    Console.WriteLine($"Lowercase: {lastName.ToLower()}\n");

    // Substring
    Console.WriteLine("Substring:");
    Console.WriteLine($"First 2 characters of first name: {firstName.Substring(0, firstName.Length)}\n");

    // Contains
    Console.WriteLine("Contains:");
    Console.WriteLine($"Does full name contain 'Patrick'? {fullName.Contains("Patrick")}\n");

    // Replace
    Console.WriteLine("Replace:");
    Console.WriteLine($"Replace 'Patrick' with 'PJM': {fullName.Replace("Patrick", "PJM")}\n");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}



