


using System.Xml.Linq;
using System.Collections.Generic;


/*Array------------------------------*/

static void array()
{
    int totalNames = 10;
    string[] listedNames = new string[10];
    for (int i = 0; i < totalNames; i++)
    {
        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        if (name == "q" || name == null)
        {
            break;
        }
        else if (listedNames.Length> 5)
        {
            break; 
        }

        else
        {
            listedNames[i] = name;
            continue;
        }


    }
    Array.Sort(listedNames);

    foreach (string name in listedNames)
    {
        Console.WriteLine(name);
    }
}
/*array(); */   

static void list()
{
    List<int> lists = new List<int>();

    while (true)
    {
        Console.WriteLine("Enter a valid number: ");
        string number = Console.ReadLine();
        if (number == "q")
        {
            break;
        }
        else
        {
            int intValue = int.Parse(number);
            if (lists.Contains(intValue))
            {
                Console.WriteLine("The number already exists");
                continue;
            }
            else if (lists.Count >= 10)
            {
                break;
            }
            else
            {
                lists.Add(intValue);
            }
        }
    }
    lists.Sort();
    foreach (int values in lists)
    {
        Console.WriteLine(values);
    }
}
/*list();*/


static void addRemoveInList()
{
    List<string> characters = new List<string>() { "soldiers", "builders", "archers", "giant", "wizards" };
    characters.Add("healer");
    PrintCharacterList(characters);
    Console.WriteLine(characters.Count);
    
}



static void PrintCharacterList(List<string> characters)
{
    string characterListing = "";
    for (int i = 0; i < characters.Count; i++)
    {
        characterListing = characterListing + characters[i] + " ";
    }
    Console.WriteLine(characterListing);
    Console.WriteLine("===========================================================");
    foreach (string character in characters)
    {
        Console.WriteLine(character);

    }
    Console.WriteLine("===========================================================");
    Console.WriteLine("Press r to remove healer from the list");
string command = Console.ReadLine();
    if (command == "r")
    {
        characters.Remove("healer");
        Console.WriteLine("healer is remover successuffly.");
        foreach (string character in characters)
        {
            Console.WriteLine(character);

        }
    }

}
addRemoveInList();