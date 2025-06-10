using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string Nickname { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public float Health { get; private set; }
    public float Critical { get; private set; }

    public Character(string nickname, int level, int gold, int attack, int defense, float health, float critical)
    {
        Nickname = nickname;
        Level = level;
        Gold = gold;
        Attack = attack;
        Defense = defense;
        Health = health;
        Critical = critical;
    }

    public struct StatChange
    {
        public int attack;
        public int defense;
        public int health;
        public float critical;
    }
}
