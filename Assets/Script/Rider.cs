using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rider : Chessman {

    // Use this for initialization
    void Start () {
        servent = 3;
        thisChessman = this.GetComponent<Rider>();
    }

    public override void ShowStep()
    {
        if(!map.HasServent(x, y + 1))
        {
            map.ShowMapClass(x, y + 2);
        }
        if (!map.HasServent(x - 1, y ))
        {
            map.ShowMapClass(x - 2, y);
        }
        if (!map.HasServent(x - 1, y - 1))
        {
            map.ShowMapClass(x - 2, y - 2);
        }
        if (!map.HasServent(x - 1, y + 1))
        {
            map.ShowMapClass(x - 2, y + 2);
        }
        if (!map.HasServent(x + 1, y))
        {
            map.ShowMapClass(x + 2, y);
        }
        if (!map.HasServent(x + 1, y - 1))
        {
            map.ShowMapClass(x + 2, y - 2);
        }
        if (!map.HasServent(x + 1, y + 1))
        {
            map.ShowMapClass(x + 2, y + 2);
        }
    }
}
