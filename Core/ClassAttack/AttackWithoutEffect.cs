using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class AttackWithoutEffect : StructAttack
{

    public PlayerCharacter myPl;
    public EnemyCharacter myEn;
    public AttackWithoutEffect(string name, string type, int attackPower, int energyCost, int precision, int criticalHit)
        : base(name, type, attackPower, energyCost, precision, criticalHit) { }



    public static List<AttackWithoutEffect> attackNoEffect = new List<AttackWithoutEffect>()
    {
        new AttackWithoutEffect("Coup de poing","Attaque", 80, 5, 20, 0),
        new AttackWithoutEffect("Coup de pied","Attaque", 30, 25, 20, 10),
        new AttackWithoutEffect("Coup de Poignard","AttaquePuissante", 80, 5, 20, 0),
        new AttackWithoutEffect("Tir a la tete","AttaqueSpecial", 30, 25, 20, 10)
    };


    public static int DamageToPlayer(int selectattack)
    {
        var def = PlayerCharacter.myPlayerChar[0].Defense;
        var damage = AttackWithoutEffect.attackNoEffect[selectattack].AttackPower;
        var perte = damage - def;
        var resultat = PlayerCharacter.myPlayerChar[0].Health - perte;
        PlayerCharacter.myPlayerChar[0].Health = resultat;
        return PlayerCharacter.myPlayerChar[0].Health;
    }

    public static int DamageToEnemy(int selectattack)
    {
        var def = EnemyCharacter.myEnemyChar[0].Defense;
        var damage = AttackWithoutEffect.attackNoEffect[selectattack].AttackPower;
        var perte = damage - def;
        var resultat = EnemyCharacter.myEnemyChar[0].Health - perte;
        EnemyCharacter.myEnemyChar[0].Health = resultat;
        return EnemyCharacter.myEnemyChar[0].Health;
    }

}
