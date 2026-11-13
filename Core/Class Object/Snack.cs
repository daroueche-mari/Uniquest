using System.Collections.Generic;
using UnityEngine;

public class Snack : InventoryObject
{
    public Snack(string name, int healingPower, int boostAttack, int boostDefense)
        : base(name, healingPower, boostAttack, boostDefense) { }


    public List<Snack> mySnack = new List<Snack>()
    {
        new Snack("Snack Faible", 10, 0, 0),
        new Snack("Snack Moyenne", 15, 0, 0)

    };
}
