using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour {

    //public PawnManager pawnManager;
    public GameManager gameManager;
    

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        gameManager.PutPawn(gameObject);
    }
}
