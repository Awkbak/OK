using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public Node mainBase;
    public int team;
    public bool isComputer;
    public Game_Environment environment;
    private Node selection;
    public Transform att;
    public Transform bal;
    public Transform def;
    Node prev;
    Node next;
    public Transform sparkles;
    public bool myturn;
    private int available;

	// Use this for initialization
	void Start () {
        available = 10;
        selection = mainBase;
        sparkles.position = mainBase.transform.position;
	}
    
    // Update is called once per frame
    void Update()
    {
        if (myturn)
        {
            if (Input.GetKeyDown("w"))
            {
                if (selection.r1 != null)
                {
                    selection = selection.r1;
                    sparkles.transform.position = selection.transform.position;
                }
            }
            else if (Input.GetKeyDown("s"))
            {
                if (selection.r2 != null)
                {
                    selection = selection.r2;
                    sparkles.transform.position = selection.transform.position;
                }
            }
            else if (Input.GetKeyDown("q"))
            {
                if (selection.l1 != null)
                {
                    selection = selection.l1;
                    sparkles.transform.position = selection.transform.position;
                }
            }
            else if (Input.GetKeyDown("a"))
            {
                if (selection.GetComponent<Node>().l2 != null)
                {
                    selection = selection.l2;
                    sparkles.transform.position = selection.transform.position;
                }
            }
            else if (Input.GetKeyDown("k"))
            {
                if (selection != null)
                {
                    if (prev != null)
                    {
                        if(!prev.hasmoved)
                        {
                            if(selection.Equals(prev.r1) || selection.Equals(prev.r2))
                            {
                                next = selection;
                                prev.attackNode(next);
                                next.hasmoved = true;
                                prev = null;
                                next = null;
                            }
                        }
                        else
                        {
                            prev = selection;
                        }
                    }
                }
            }
        }
    }
    public void StartTurn()
    {
        available += 2;
    }
    void moveStuff(Node a, Node b)
    {

    }
    void attack()
    {

    }
    public void assign(int ID)
    {
        if (available > 0)
        {
            switch (ID)
            {
                case 0:
                    mainBase.addUnit(att);
                    break;
                case 1:
                    mainBase.addUnit(bal);
                    break;
                case 2:
                    mainBase.addUnit(def);
                    break;
            }
            available--;
        }
    }
}
