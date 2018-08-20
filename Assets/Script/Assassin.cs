using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassin : Chessman {

    // Use this for initialization
    void Start () {
        servent = 5;
        thisChessman = this.GetComponent<Assassin>();
    }
	
    public override void ShowStep()
    {
        int tempx = x;
        int tempy = y;
        while (map.ShowMapClass(++tempx, ++tempy)) ;
        tempx = x;
        tempy = y;
        while (map.ShowMapClass(++tempx, --tempy)) ;
        tempx = x;
        tempy = y;
        while (map.ShowMapClass(--tempx, ++tempy)) ;
        tempx = x;
        tempy = y;
        while (map.ShowMapClass(--tempx, --tempy)) ;
    }

}
