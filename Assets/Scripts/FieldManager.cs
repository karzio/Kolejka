using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour {

    public PawnManager pawnManager;
    

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().enabled = false;
        //pawnManager = pawnManager.GetComponent<PawnManager>();
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
        pawnManager.PutPawn();
    }
}
