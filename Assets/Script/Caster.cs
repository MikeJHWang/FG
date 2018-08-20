using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caster : Chessman {

	// Use this for initialization
	void Start () {
        servent = 4;
        thisChessman = this.GetComponent<Caster>();
    }

    public override void ShowStep()
    {
        if (!map.HasServent(x - 1, y))
        {
            map.ShowMapClass(x - 2, y - 1);
            map.ShowMapClass(x - 2, y + 1);
        }
        if (!map.HasServent(x, y - 1))
        {
            map.ShowMapClass(x - 1, y - 2);
            map.ShowMapClass(x + 1, y - 2);
        }
        if (!map.HasServent(x, y + 1))
        {
            map.ShowMapClass(x - 1, y + 2);
            map.ShowMapClass(x + 1, y + 2);
        }
        if (!map.HasServent(x + 1, y))
        {
            map.ShowMapClass(x + 2, y - 1);
            map.ShowMapClass(x + 2, y + 1);
        }
    }
 }
