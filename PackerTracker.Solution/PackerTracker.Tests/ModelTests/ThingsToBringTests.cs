using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ThingsToBringTests
  {
    [TestMethod]
    public void ThingsToBringConstructor_CreateConstructor_ThingsToBring()
    {
      ThingsToBring newThing = new ThingsToBring();
      Assert.AreEqual(typeof(ThingsToBring), newThing.GetType());
    }

    [TestMethod]
    public void ThingsToBringConstructor_InstanceStoresNameOfThing_String()
    {
      string expected = "Snowboard";
      ThingsToBring newThing = new ThingsToBring(expected);
      string result = newThing.Name;
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ThingsToBringConstructor_ConstructorStoresAllProperties_ThingsToBringInstance()
    {
      string itemName = "Snowboard";
      int price = 2;
      bool isPurchased = false;
      int weight = 2;
      string manufacturer = "Northface";
      bool isPacked = false;
      
      ThingsToBring newThing = new ThingsToBring(itemName, price, isPurchased, weight, manufacturer, isPacked);

      Assert.AreEqual(itemName, newThing.Name);
      Assert.AreEqual(price, newThing.Price);
      Assert.AreEqual(isPurchased, newThing.IsPurchased);
      Assert.AreEqual(weight, newThing.Weight);
      Assert.AreEqual(manufacturer, newThing.Manufacturer);
      Assert.AreEqual(isPacked, newThing.IsPacked);
    }

    [TestMethod]
    public void GetAll_GetsEmptyList_ListOfThingsToBring()
    {
      List<ThingsToBring> expected = new List<ThingsToBring> { };
      ThingsToBring newThing = new ThingsToBring();
      ThingsToBring.ListOfThingsToBring = new List<ThingsToBring> { };
      List<ThingsToBring> result = ThingsToBring.GetAll();
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetAll_GetsListOfThingsToBring_ListOfThingsToBring()
    {
      string description1 = "Ski jacket";
      string description2 = "Snowboard";
      string description3 = "Hot Chocolate";

      ThingsToBring newThing1 = new ThingsToBring(description1);
      ThingsToBring newThing2 = new ThingsToBring(description2);
      ThingsToBring newThing3 = new ThingsToBring(description3); 

      List<ThingsToBring> expected = new List<ThingsToBring> {newThing1, newThing2, newThing3};

      // Constructor will automatically add each thing instance to our list
      List<ThingsToBring> result = ThingsToBring.GetAll();
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ClearAll_ClearsListOfThingsToBring_ClearsListOfThingsToBring()
    {
      string description1 = "Ski jacket";
      string description2 = "Snowboard";
      string description3 = "Hot Chocolate";

      ThingsToBring newThing1 = new ThingsToBring(description1);
      ThingsToBring newThing2 = new ThingsToBring(description2);
      ThingsToBring newThing3 = new ThingsToBring(description3); 

      ThingsToBring.ClearAll();
      List<ThingsToBring> expected = new List<ThingsToBring> { };
      List<ThingsToBring> result = ThingsToBring.GetAll();
      CollectionAssert.AreEqual(expected, result);
    }
  }
}