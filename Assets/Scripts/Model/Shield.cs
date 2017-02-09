using System.Collections;
using System;

[Serializable]
public class Shield {
    public string name;
    public Grade[] grade;
    public Shield() {
        grade = new Grade[3];
    }
}

