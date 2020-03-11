using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class ThingsToBring
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public string IsPurchasedInput { get; set; }
    public bool IsPurchased {get; set;}
    public int Weight { get; set; }
    public string Manufacturer { get; set; }
    public string IsPackedInput {get; set;}
    public bool IsPacked {get; set;}

    private static List<ThingsToBring> ListOfThingsToBring = new List<ThingsToBring> { };

    public ThingsToBring()
    {
      ListOfThingsToBring.Add(this);
    }
    
    public ThingsToBring(string name)
    {
      Name = name;
      ListOfThingsToBring.Add(this);
    }

    public ThingsToBring(string name, int price, string isPurchased, int weight, string manufacturer, string isPacked)
    {
      Name = name;
      Price = price;
      IsPurchasedInput = isPurchased;

      Weight = weight;
      Manufacturer = manufacturer;

      IsPackedInput = isPacked;
      ChecksBools();
      ListOfThingsToBring.Add(this);
    }

    public void ChecksBools()
    {
      if(IsPurchasedInput == "true")
      {
        IsPurchased = true;
      }
      else if (IsPurchasedInput == "false")
      {
        IsPurchased = false;
      }
      if (IsPackedInput == "true")
      {
        IsPacked = true;
      }
      else if (IsPurchasedInput == "false")
      {
        IsPurchased = false;
      }
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