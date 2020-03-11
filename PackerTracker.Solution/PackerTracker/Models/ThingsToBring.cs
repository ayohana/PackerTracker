using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class ThingsToBring
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public bool IsPurchased { get; set; }
    public int Weight { get; set; }
    public string Manufacturer { get; set; }
    public bool IsPacked {get; set;}

    public static List<ThingsToBring> ListOfThingsToBring { get; set; }

    public ThingsToBring()
    {
      ListOfThingsToBring = new List<ThingsToBring> { };
      ListOfThingsToBring.Add(this);
    }
    
    public ThingsToBring(string name)
    {
      Name = name;
      ListOfThingsToBring.Add(this);
    }

    public ThingsToBring(string name, int price, bool isPurchased, int weight, string manufacturer, bool isPacked)
    {
      Name = name;
      Price = price;
      IsPurchased = isPurchased;
      Weight = weight;
      Manufacturer = manufacturer;
      IsPacked = isPacked;
      ListOfThingsToBring.Add(this);
    }

    public static List<ThingsToBring> GetAll()
    {
      return ListOfThingsToBring;
    }

    public static void ClearAll()
    {
      ListOfThingsToBring.Clear();
    }

  }
}