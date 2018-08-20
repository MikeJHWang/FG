using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    private int[,] map = new int[9,7];
    private MapClass[,] mapClasses = new MapClass[9, 7];
    // Use this for initialization
    void Start () {
        for (int i = 1; i < 8; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                map[i, j] = -1;
            }
        }
        for (int i = 0; i < 7; i++)
        {
            map[0,i] = i;
            map[8, i] = i + 7;
        }
        for (int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                Transform mc = GameObject.Find("MapClass").transform;
                mapClasses[i, j] = mc.Find("map"+i.ToString()+j.ToString()).GetComponent<MapClass>();
                mapClasses[i, j].NotShow();
            }
        }
    }
	
    public bool ShowMapClass(int x, int y)
    {

        if(HasServent(x, y))
        { 
            return false;
        }
        mapClasses[x, y].Show();
        return true;
    }

    public bool HasServent(int x, int y)
    {
        if (x > 8 || x < 0 || y < 0 || y > 6)
        {
            return true;
        }
        if (map[x, y] == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Move(int x, int y, int endx, int endy)
    {
        map[endx, endy] = map[x, y];
        map[x, y] = -1;
        MapNotShow();
    }

    public Vector3 GetPosition(int x, int y)
    {
        return mapClasses[x, y].transform.position;
    }

    public void MapNotShow()
    {
        foreach (MapClass i in mapClasses)
        {
            i.NotShow();
        }
    }
}
