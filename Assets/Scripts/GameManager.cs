using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] GameObject vendor;
    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    //PlayerManager[] players = new PlayerManager[4];

    // Use this for initialization
    void Start ()
    { }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PutPawn(GameObject field)
    {
        Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Pawn.prefab", typeof(GameObject));
        GameObject pawn = Instantiate(prefab, field.transform.position, field.transform.rotation) as GameObject;
        // Modify the clone to your heart's content
        pawn.transform.SetParent(field.transform);
        pawn.SetActive(true);

    }
}

