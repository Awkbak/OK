using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Node : MonoBehaviour {
    private int attack;
    private int health;
    private int shield;
    public int team;
    public bool mainbase;
    public Node r1, r2, l1, l2;
    private Stack<Unit> allUnits;
    private float heuristic;
    public bool hasmoved;

    // Use this for initialization
    void Start () {
        attack = 0;
        health = 0;
        shield = 0;
        allUnits = new Stack<Unit>();
        hasmoved = false;
	}

    public void addUnit(Transform ds)
    {
        int i = allUnits.Count;
        var xpos = transform.position.x + 0.35f *Mathf.Cos(Mathf.PI / 4 * i);
        var zpos = transform.position.z + 0.35f *Mathf.Sin(Mathf.PI / 4 * i);
        var ypos = transform.position.y;
        Transform unit = Instantiate(ds, new Vector3(xpos,ypos + 0.1f + 0.1f * i, zpos), transform.rotation) as Transform;
        Unit s = unit.GetComponent<Unit>();
        allUnits.Push(s);
        attack += s.attack;
        health += s.health;
        shield += s.shield;

    }

    void transferunit(Transform ds)
    {
        int i = allUnits.Count;
        var xpos = transform.position.x + 0.35f * Mathf.Cos(Mathf.PI / 4 * i);
        var zpos = transform.position.z + 0.35f * Mathf.Sin(Mathf.PI / 4 * i);
        var ypos = transform.position.y;
        ds.position = new Vector3(xpos, ypos + 0.1f + 0.1f * i, zpos);
        Unit s = ds.GetComponent<Unit>();
        allUnits.Push(s);
        attack += s.attack;
        health += s.health;
        shield += s.shield;
    }

    public void attackNode(Node bleh)
    {
        while (allUnits.Count > 0)
        {
            bleh.transferunit(allUnits.Pop().transform);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
