using UnityEngine;

public class Entity
{

    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
    private int _health = 100;
    public int Health
    {
        get { return _health; }
        set {_health = Mathf.Clamp(value, 0, 100);  }
    }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    public int Precision { get; set; }
    public int Energy { get; set; }
    

    public Entity(string name, string type, int level, int health, int attack, int defense, int speed, int precision, int energy)
    {
        Name = name; Type = type; Level = level; Health = health; Attack = attack; Defense = defense; Speed = speed; Precision = precision; Energy = energy;
    }
}