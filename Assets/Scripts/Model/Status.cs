using UnityEngine;
using System;

[Serializable]
public class Status  {
    public int attack;
    public int health;
    public int critical;
    public int critical_damage;
    public int critical_res;
    public int hit;
    public int dodge;

    public Status() {
        attack = 0;
        health = 0;
        critical = 0;
        critical_damage = 0;
        critical_res = 0;
        hit = 0;
        dodge = 0;
    }
}
