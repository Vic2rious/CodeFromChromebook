//Victor Ivanov 12/1

using System;
using System.Collections.Generic;

public class Dictinoary_VictorIvanov {
  public static void Main (string[] args){

    Dictionary<string, int> phonebook  = new Dictionary<string, int>();
    bool loop = true;
    int x = 0;

    while (loop) {
        x = 0;
        Console.WriteLine();
        Console.WriteLine("Choose an option (type number): ");
        Console.WriteLine("1) Read Contacts");
        Console.WriteLine("2) Add a Contact");
        Console.WriteLine("3) Search a Contact");
        Console.WriteLine("4) Delete a Contact");
        Console.WriteLine("5) Exit");

        try {
          x = Convert.ToInt32(Console.ReadLine());
        } catch (Exception e){

        }

        switch(x) {
          case 1:
            Console.WriteLine("The list is as follows:");
            Console.WriteLine();

            if(phonebook.Count == 0) {
              Console.WriteLine("There is nothing entered in the phonebook!");
            } else {
                foreach(var kvp in phonebook) {
                  Console.WriteLine(kvp.Key + " " + kvp.Value);
              }
            }

          break;
          case 2:
          Console.WriteLine("Write the first name and number separated by space:");
          string s = Console.ReadLine();
          string[] subs = s.Split(' ');
          try {
            phonebook.Add(subs[0], Convert.ToInt32(subs[1]));
          } catch (Exception e) {
            Console.WriteLine("Wrong input!");
          }
          break;
          case 3:
          Console.WriteLine("Write the name of the contact you would like to search:");
          string name = Console.ReadLine();
          if(phonebook.ContainsKey(name) == true) {
            Console.WriteLine("The number to " + name + " is " + phonebook[name]);
          } else {
            Console.WriteLine("The name " + name + " isn't associated to any number!");
          }
          break;
          case 4:
          Console.WriteLine("Write the name of the contact you would like to delete:");
          string del_name = Console.ReadLine();
          if(phonebook.ContainsKey(del_name) == true) {
            Console.WriteLine("The contact " + del_name + " was deleted!");
            phonebook.Remove(del_name);
          } else {
            Console.WriteLine("The name isn't associated to any number!");
          }
          break;
          case 5:
          loop = false;
          break;
          default:
          Console.WriteLine("Not an available option, try again");
          Console.WriteLine();
          break;
        }

    }

  }
}
