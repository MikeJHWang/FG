using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour {
    protected int x;
    protected int y;
    protected GameSystem gs;
    protected Map map;
    //0 red, 1 black
    public int flag;
    protected int servent;
    protected Chessman thisChessman;

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            map.MapNotShow();
        }
    }

    public void SetStartPoint(int x, int y)
    {
        gs = GameObject.Find("GameSystem").GetComponent<GameSystem>();
        map = gs.GetMap();
        this.x = x;
        this.y = y;
    }

    void OnMouseDown()
    {
        if(gs.GetFlag() == flag && !gs.HasMoved())
        {
            map.MapNotShow();
            ShowStep();
            gs.nowClick = flag * 7 + servent;
        }
        
        if (gs.GetFlag() == flag && !gs.HasSkilled())
        {
            gs.skillButton.SetActive(true);
        }
        else
        {
            gs.skillButton.SetActive(false);
        }
    }

    public virtual void ShowStep()
    {

    }

    public void Move(int endx, int endy)
    {
        this.transform.position = map.GetPosition(endx, endy) - new Vector3(0,0,5);
        map.Move(x, y, endx, endy);
        this.x = endx;
        this.y = endy;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }
}

