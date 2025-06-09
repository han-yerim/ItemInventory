using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string nickname;
    public int attack;
    public int defense;
    public int health;
    public float critical;

    public Character(string nickname, int attack, int defense, int health, float critical)
    {
        this.nickname = nickname;
        this.attack = attack;
        this.defense = defense;
        this.health = health;
        this.critical = critical;
    }
}
