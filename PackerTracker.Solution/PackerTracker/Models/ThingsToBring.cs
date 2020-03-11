using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class ThingsToBring
  {
    public string Name { get; set; }
    public int Id { get; }
    public int Price { get; set; }
    public string IsPurchasedInput { get; set; }
    public bool IsPurchased {get; set;}
    public int Weight { get; set; }
    public string Manufacturer { get; set; }
    public string IsPackedInput {get; set;}
    public bool IsPacked {get; set;}

    private static List<ThingsToBring> _listOfThingsToBring = new List<ThingsToBring> { };

    public ThingsToBring()
    {
      _listOfThingsToBring.Add(this);
      Id = _listOfThingsToBring.Count;
    }
    
    public ThingsToBring(string name)
    {
      Name = name;
      _listOfThingsToBring.Add(this);
      Id = _listOfThingsToBring.Count;
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
      _listOfThingsToBring.Add(this);
      Id = _listOfThingsToBring.Count;
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
      return _listOfThingsToBring;
    }

    public static void ClearAll()
    {
      _listOfThingsToBring.Clear();
    }

    public static ThingsToBring Find(int searchId)
    {
      return _listOfThingsToBring[searchId-1];
    }

  }
}