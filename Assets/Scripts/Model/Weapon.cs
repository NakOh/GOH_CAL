using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class Weapon {
    public string name;
    public Grade[] grade;

    public Weapon() {
        grade = new Grade[3];
    }
}
    
