using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {
    public int nowClick;
    private int flag;
    private Chessman[] chessman = new Chessman[14];
    private Map map;
    private bool move = false;
    private bool skill = false;
    public GameObject skillButton;
    // Use this for initialization
    void Start () {
        map = this.GetComponent<Map>();

        chessman[0] = GameObject.Find("RedSaber").GetComponent<Saber>();
        chessman[0].SetStartPoint(0, 0);
        chessman[1] = GameObject.Find("RedArcher").GetComponent<Archer>();
        chessman[1].SetStartPoint(0, 1);
        chessman[2] = GameObject.Find("RedLancer").GetComponent<Lancer>();
        chessman[2].SetStartPoint(0, 2);
        chessman[3] = GameObject.Find("RedRider").GetComponent<Rider>();
        chessman[3].SetStartPoint(0, 3);
        chessman[4] = GameObject.Find("RedCaster").GetComponent<Caster>();
        chessman[4].SetStartPoint(0, 4);
        chessman[5] = GameObject.Find("RedAssassin").GetComponent<Assassin>();
        chessman[5].SetStartPoint(0, 5);
        chessman[6] = GameObject.Find("RedBerserker").GetComponent<Berserker>();
        chessman[6].SetStartPoint(0, 6);
        chessman[7] = GameObject.Find("BlackSaber").GetComponent<Saber>();
        chessman[7].SetStartPoint(8, 0);
        chessman[8] = GameObject.Find("BlackArcher").GetComponent<Archer>();
        chessman[8].SetStartPoint(8, 1);
        chessman[9] = GameObject.Find("BlackLancer").GetComponent<Lancer>();
        chessman[9].SetStartPoint(8, 2);
        chessman[10] = GameObject.Find("BlackRider").GetComponent<Rider>();
        chessman[10].SetStartPoint(8, 3);
        chessman[11] = GameObject.Find("BlackCaster").GetComponent<Caster>();
        chessman[11].SetStartPoint(8, 4);
        chessman[12] = GameObject.Find("BlackAssassin").GetComponent<Assassin>();
        chessman[12].SetStartPoint(8, 5);
        chessman[13] = GameObject.Find("BlackBerserker").GetComponent<Berserker>();
        chessman[13].SetStartPoint(8, 6);
        RedTurn();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public Map GetMap()
    {
        return map;
    }

    public void Move(int id, int x, int y)
    {
        chessman[id].Move(x, y);
        move = true;
        if (skill)
        {
            TurnEnd();
        }
    }

    private void RedTurn()
    {
        print("Turn Red");
        flag = 0;
        move = false;
        skill = false;
        
    }

    private void BlackTurn()
    {
        print("Turn Black");
        flag = 1;
        move = false;
        skill = false;
    }

    public void NoblePhantasm()
    {
        if (!skill)
        {
            print("skill");
            skill = true;
            skillButton.SetActive(false);
        }
        if (move)
        {
            TurnEnd();
        }
    }

    public void TurnEnd()
    {
        skillButton.SetActive(false);
        if (flag == 0)
        {
            BlackTurn();
        }
        else
        {
            RedTurn();
        }
    }

    public bool HasMoved()
    {
        return move;
    }

    public bool HasSkilled()
    {
        return skill;
    }

    public int GetFlag()
    {
        return flag;
    }
}

