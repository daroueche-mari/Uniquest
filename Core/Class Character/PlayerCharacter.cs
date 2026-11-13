using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;


public class PlayerCharacter : Entity
{
    public PlayerCharacter(string name, string type, int level, int health, int attack, int defense, int speed, int precision, int energy) 
        : base(name, type, level, health, attack, defense, speed, precision, energy) { }


   public static List<PlayerCharacter> myPlayerChar = new List<PlayerCharacter>
    {
        new PlayerCharacter("Joueur", "Aventurier", 1, 100, 30, 25, 15, 20, 100)
    };

    

}