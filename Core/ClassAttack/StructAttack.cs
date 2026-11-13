using UnityEngine;

public class StructAttack
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int AttackPower { get; set; }
    public int EnergyCost { get; set; }
    public int Precision {  get; set; }
    public int CriticalHit {  get; set; }

   

    public StructAttack(string name, string type, int attackPower, int energyCost, int precision, int criticalHit)
    {
        Name = name; Type = type; AttackPower = attackPower; EnergyCost = energyCost; Precision = precision; CriticalHit = criticalHit;
    }



}
