


using System.Xml.Linq;
using System.Collections.Generic;
using System.Collections;


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
/*addRemoveInList();
*/

static void arrrangeData()
{
    List<List<string>> TableOfLists = new List<List<string>>();

    while (true)
    {
        Console.WriteLine("Press 1 to add friends, press 2 to add items, press 3 to exit");
        int action = int.Parse(Console.ReadLine());
        if (action == 3)
        {
            break;
        }
        else if (action == 1)
        {
            
            while (true)
            {
                List<string> list = new List<string>();

                Console.WriteLine("Add a friend or press q to exit.");
                string friend = Console.ReadLine();
                if (friend== "q")
                {
                    break;
                }
                else
                {
                    list.Add(friend);
                    continue;
                }
            }
        }

    }
    Console.WriteLine("the items" );
    Console.WriteLine(TableOfLists.Count);


    /*
    foreach (List<string> subList in myList)
{
    foreach (string item in subList)
    {
        Console.WriteLine(item);
    }
}
    
             */



    /*  for (int i = 0; i < 3;i++)
      {
          for (int x= 0; x < TableOfLists[i].Count;x++)
          {
              Console.WriteLine(TableOfLists[i][x].ToString());
          }
      }
      foreach (List<string> lists in TableOfLists)
      {
          foreach (string item in lists)
          {
              Console.WriteLine(item);
          }
      }*/


}
arrrangeData();
