using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : Chessman
{
    // Use this for initialization
    void Start () {
        servent = 0;
        thisChessman = this.GetComponent<Saber>();
    }

    public override void ShowStep()
    {
        map.ShowMapClass(x, y - 1);
        map.ShowMapClass(x, y + 1);
        map.ShowMapClass(x-1, y);
        map.ShowMapClass(x - 1, y - 1);
        map.ShowMapClass(x - 1, y + 1);
        map.ShowMapClass(x + 1, y);
        map.ShowMapClass(x + 1, y - 1);
        map.ShowMapClass(x + 1, y + 1);
    }
}
