using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//transform.position = new Vector3(-280, 400, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
        // detta tar bort texten "press "space" to start" från skärmen
		if (Input.GetKey(KeyCode.Space))
		{
            gameObject.SetActive(false);
		}
	}
}
