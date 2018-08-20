using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Chessman {

    // Use this for initialization
    void Start () {
        servent = 6;
        thisChessman = this.GetComponent<Caster>();
    }

    public override void ShowStep()
    {

        for (int i = x; (flag == 0 ? i < 9 : i > 0); i += (flag == 0 ? 1 : -1))
        {
            for(int j = 0;j < 7; j++)
            {
                map.ShowMapClass(i, j);
            }
        }
        
    }
}
