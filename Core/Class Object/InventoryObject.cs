using UnityEngine;

public class InventoryObject
{
    public string Name { get; set; }
    public int HealingPower { get; set; }
    public int BoostAttack { get; set; }
    public int BoostDefense { get; set; }

    public Potion myPo;
    public PlayerCharacter playerChar;
    public EnemyCharacter enemyChar;
    public InventoryObject(string name, int  healingPower, int boostAttack, int boostDefense)
    {
        Name = name; HealingPower = healingPower; BoostAttack = boostAttack; BoostDefense = boostDefense;
    }

}
