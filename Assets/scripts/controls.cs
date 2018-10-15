using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

    // "Bool" statar skepet
    // float "MoveSpeed" bestemer vad skepet's hastighet
    // float "rotatespeedleft/right" gör att skepets rotation har sin enga variabel

bool hasStarted = false;
public float MoveSpeed = 6;
    public float rotatespeedleft = 360;
    public float rotatespeedright = 360;
    // Use this for initialization
    void Start () 
	{
        MoveSpeed = Random.Range(1f, 10f);
	}
	
	// Update is called once per frame
	void Update () 
	{
        // gör så att "space" startar spelet
        if (Input.GetKey(KeyCode.Space))
        {
            hasStarted = true;
        }
        // gör att skeppet åker konstant framåt
		if(hasStarted)
		{
			transform.Translate(0, -MoveSpeed * Time.deltaTime, 0, Space.Self);
		}
        // dom här 6 linjerna av kod gör så att skeppet kan styras av A, D, S
		if (Input.GetKey(KeyCode.A))
		{
			transform.Rotate(0, 0, rotatespeedleft * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0, 0, -rotatespeedright * Time.deltaTime);
		}
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, (MoveSpeed/2) * Time.deltaTime, 0, Space.Self);
        }


	}
}
