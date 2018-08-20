using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancer : Chessman
{
    // Use this for initialization
    void Start () {
        servent = 2;
        thisChessman = this.GetComponent<Lancer>();
    }

    public override void ShowStep()
    {
        map.ShowMapClass(x - 1, y - 1);
        map.ShowMapClass(x - 1, y + 1);
        map.ShowMapClass(x + 1, y - 1);
        map.ShowMapClass(x + 1, y + 1);
    }
}
