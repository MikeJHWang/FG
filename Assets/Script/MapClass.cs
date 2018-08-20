using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapClass : MonoBehaviour {
    private int x;
    private int y;
    private bool useable = false;
    public Sprite show;
    private SpriteRenderer sr;
    private GameSystem gs;
	// Use this for initialization
	void Start () {
        sr = this.GetComponent<SpriteRenderer>();
        x = int.Parse(this.name.Substring(3, 1));
        y = int.Parse(this.name.Substring(4, 1));
        gs = GameObject.Find("GameSystem").GetComponent<GameSystem>();
    }

   void OnMouseDown()
    { 
        if (useable)
        {
            gs.Move(gs.nowClick, x, y);   
        }
    }

    public void Show()
    {
        sr.sprite = show;
        useable = true;
    }

    public void NotShow()
    {
        sr.sprite = null;
        useable = false;
    }
}
