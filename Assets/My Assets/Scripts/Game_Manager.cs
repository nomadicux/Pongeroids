using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour {

    public bool gameOn = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (gameOn == false)
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
	
	}
}
