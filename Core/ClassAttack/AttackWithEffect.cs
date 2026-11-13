using System.Collections.Generic;
using UnityEngine;

public class AttackWithEffect : StructAttack
{
    public int Effect {  get; set; }
    


    public AttackWithEffect(int effect,string name, string type, int attackPower, int energyCost, int precision, int criticalHit)
        : base(name, type, attackPower, energyCost, precision, criticalHit)
    {
        Effect = effect; 
    }


    public static List<AttackWithEffect> attackNoEffect = new List<AttackWithEffect>()
    {
        new AttackWithEffect(5, "Etrangler","Physique", 15, 5, 20, 0)

    };

   

}
