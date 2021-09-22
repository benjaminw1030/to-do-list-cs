using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      //use getter/setter to add to list
      //use Item.GetAll to display list of tasks.
      Console.WriteLine("TO-DO LIST");
      Console.WriteLine("------------------");
      Console.WriteLine("");
      Console.WriteLine("Welcome to the To-Do List!");
      Menu();
    }

    public static void Menu()
    {
      List<Item> toDoList = Item.GetAll();
      Console.WriteLine("");
      Console.WriteLine("Would you like to add an item or view the list? (add/view/quit)");
      string userSelect = Console.ReadLine();
      if (userSelect == "add")
      {
        Console.WriteLine("");
        Console.WriteLine("What item are you adding?");
        string inputItem = Console.ReadLine();
        Item newItem = new Item(inputItem);
        Console.WriteLine("");
        Console.WriteLine($"{toDoList.Count} items added to list.");
        Menu();
      }
      else if (userSelect == "view")
      {
        if (toDoList.Count == 0)
        {
          Console.WriteLine("");
          Console.WriteLine("Please add an item to the list.");
          Menu();
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("To Do:");
          foreach (Item element in toDoList)
          {
            Console.WriteLine(element.Description);
          }
          Menu();
        }
      }
      else if (userSelect == "quit")
      {
        Console.WriteLine("");
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Please select an option.");
        Menu();
      }
    }
  }
}
