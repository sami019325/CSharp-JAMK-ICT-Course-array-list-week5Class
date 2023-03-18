


using System.Xml.Linq;
using System.Collections.Generic;
using System.Collections;


/*============================================================================================================================
----------------------------------------------------------problem-------------------------------------------------------------
==============================================================================================================================*/


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
