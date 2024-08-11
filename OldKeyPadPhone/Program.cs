using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(OldKeyPadPhone.InputStringOldKeyPadPhone("33#")); 
        Console.WriteLine(OldKeyPadPhone.InputStringOldKeyPadPhone("227*#")); 
        Console.WriteLine(OldKeyPadPhone.InputStringOldKeyPadPhone("4433555 555666#")); 
        Console.WriteLine(OldKeyPadPhone.InputStringOldKeyPadPhone("8 88 777 444 666* 664#")); 

        Console.WriteLine("Enter the key sequence (end with '#'):");

        // Read the input from the console
        string input = Console.ReadLine();

        // Process the input and get the result
        string result = OldKeyPadPhone.InputStringOldKeyPadPhone(input);

        // Output the result
        Console.WriteLine("Output: " + result);
    }
}
