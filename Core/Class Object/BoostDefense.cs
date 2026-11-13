using System.Collections.Generic;
using UnityEngine;

public class BoostDefense : InventoryObject
{
    public BoostDefense(string name, int healingPower, int boostAttack, int boostDefense)
        : base(name, healingPower, boostAttack, boostDefense) { }


    public List<BoostDefense> myPotion = new List<BoostDefense>()
    {
        new BoostDefense("Defense+", 0, 0, 10),
        new BoostDefense("Defense++", 0, 0, 15)

    };
}
