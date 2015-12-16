using UnityEngine;
using System.Collections;

public class Game_Environment : MonoBehaviour {
    public Node purpleBase;
    public Node blueBase;
    public Player p1;
    public Player p2;
    public static float difficulty;
    public Transform nodecol;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void setDifficulty(float d)
    {
        difficulty = d;
    }

    //Changes turns
    public void turns()
    {
        for(int i = 0; i<nodecol.childCount;i++)
        {
            nodecol.GetChild(i).GetComponent<Node>().hasmoved = false;
        }
        p1.myturn = !p1.myturn;
        p2.myturn = !p2.myturn;
        if (p2.myturn)
        {
            p2.Gomyturn();
        }
    }
}
