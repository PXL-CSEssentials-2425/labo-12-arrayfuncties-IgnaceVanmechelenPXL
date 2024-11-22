using System;

string[] names = new string[10] {"Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom"};
Console.WriteLine("Gelieve een naam in te geven");
string userNameInput = Console.ReadLine();
int indexOfUserInput = Array.IndexOf(names, userNameInput) + 1;
if (indexOfUserInput > 0)
{
    Console.WriteLine($"de naam {userNameInput} staat op plaats {indexOfUserInput}");
}
else
{
    Console.WriteLine("de ingevoerde naam staat niet op de lijst");
}
Console.WriteLine("gelieve een letter in te geven");
string userLetterInput = Console.ReadLine();
if (!string.IsNullOrEmpty(userLetterInput) && char.IsLetter(userLetterInput[0]))
{
    char firstLetter = char.ToLower(userLetterInput[0]);
    string[] namesStartWithLetter = Array.FindAll(names, element => element.ToUpper().StartsWith(userLetterInput.ToUpper()));
    if (namesStartWithLetter.Length > 0)
    {
        Console.WriteLine($"Namen die beginnen met de letter {userLetterInput}: {string.Join(", ", namesStartWithLetter)}");
    }
    else
    {
        Console.WriteLine($"Er zijn geen namen die beginnen met de letter {userLetterInput}");
    }
}
Console.WriteLine("Gelieve een begingetal tussen 1 en 10 in te geven:");
string inputStartIndex = Console.ReadLine();
Console.WriteLine("Gelieve een eindgetal tussen 1 en 10 in te geven:");
string inputEndIndex = Console.ReadLine();

bool resultOne = int.TryParse(inputStartIndex, out int startIndex);
bool resultTwo = int.TryParse (inputEndIndex, out int endIndex);
if (resultOne == true && resultTwo == true)
{
    if (startIndex >=0 && startIndex <= names.Length && endIndex >=0 && endIndex <= names.Length && endIndex >= startIndex)
    {
        int length = endIndex - startIndex +1;
        Array.Sort(names, startIndex, length);
        Console.WriteLine(string.Join(", ", names));
    }
    else
    {
        Console.WriteLine("Onjuiste lengte, nummer past niet binnen lengte array");
    }
}
else
{
    Console.WriteLine("geef 2 correcte nummers");
}
Console.ReadKey();