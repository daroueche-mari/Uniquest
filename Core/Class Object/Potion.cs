using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Potion : InventoryObject
{
    public Potion(string name, int healingPower, int boostAttack, int boostDefense) 
        : base(name, healingPower, boostAttack, boostDefense) { }



    public List<Potion> myPotion = new List<Potion>()
    {
        new Potion("Potion Faible", 15, 0, 0),
        new Potion("Potion Moyenne", 20, 0, 0)

    };
}
