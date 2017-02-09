using System.Collections;
using System;

[Serializable]
public class Shoes {
    public string name;
    public Grade[] grade;
    public Shoes() {
        grade = new Grade[3];
    }
}
