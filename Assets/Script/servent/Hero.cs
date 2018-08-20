using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
    public string heroName;
    protected Chessman chessman;
    protected Map map;
    protected GameSystem gs;
    // Use this for initialization
    void Start () {
        gs = GameObject.Find("GameSystem").GetComponent<GameSystem>();
        map = gs.GetMap();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Attack()
    {

    }

    public virtual void Died()
    {

    }
}
