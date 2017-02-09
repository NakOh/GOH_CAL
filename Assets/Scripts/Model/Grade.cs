using System.Collections.Generic;
using System;

[Serializable]
public class Grade {
    public Status[] reinforce;

    public Grade() {
        reinforce = new Status[5];
        for(int i = 0; i < 4; i++) 
            reinforce[i] = new Status();        
    }
}
