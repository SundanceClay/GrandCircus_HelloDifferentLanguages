// See https://aka.ms/new-console-template for more information
string userLoop = "y";
do
{
    Console.WriteLine("Enter a language or n to stop: ");
    string userInput = (Console.ReadLine()).ToLower();

    switch (userInput) 
    {
        case "english":
            Console.WriteLine("Hello World!");
            break;
        case "spanish":
            Console.WriteLine("Hola Mundo!");
            break;
        case "french":
            Console.WriteLine("Bonjour le monde!");
            break;
        case "n":
            userLoop = "n";
            break;
        default:
            Console.WriteLine("I don't know that one!");
            break;
    }
}
while (userLoop != "n");

