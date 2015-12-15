using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Main_Menu : MonoBehaviour {

    public Slider diff;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Game_Environment.setDifficulty(diff.value);
	}

    //Change to the game
    public void changeToGame()
    {
        Application.LoadLevel("Game");
    }

    //Change to Instructions screen
    public void changeToInstructions()
    {
        Application.LoadLevel("Instructions");
    }
}
