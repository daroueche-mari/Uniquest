using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Entity
{
    public EnemyCharacter(string name, string type, int level, int health, int attack, int defense, int speed, int precision, int energy) 
        : base(name, type, level, health, attack, defense, speed, precision, energy) { }





    public static List<EnemyCharacter> myEnemyChar = new List<EnemyCharacter>
    {
        new EnemyCharacter("Enemy", "Combattant", 1, 100, 20, 15, 5, 10, 100),
        new EnemyCharacter("SuperEnemy", "Competiteur", 10, 100, 50, 30, 40, 60, 100)

    };
}
