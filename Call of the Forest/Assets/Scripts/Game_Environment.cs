using UnityEngine;
using System.Collections;

public class Game_Environment : MonoBehaviour {
    public Node purpleBase;
    public Node blueBase;
    public Player p1;
    public Player p2;
    public static float difficulty;

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
        p1.myturn = !p1.myturn;
        p2.myturn = !p2.myturn;
    }
}
