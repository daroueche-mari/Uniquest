using System.Collections.Generic;
using UnityEngine;

public class BoostAttack : InventoryObject
{
    public BoostAttack(string name, int healingPower, int boostAttack, int boostDefense)
        : base(name, healingPower, boostAttack, boostDefense) { }


    public List<BoostAttack> myPotion = new List<BoostAttack>()
    {
        new BoostAttack("Attaque+", 0, 10, 0),
        new BoostAttack("Attaque++", 0, 15, 0)

    };
}
