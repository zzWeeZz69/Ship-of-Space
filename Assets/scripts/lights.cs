using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
    public SpriteRenderer color;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            color.color = Color.green;
        }
        if (Input.GetKey(KeyCode.D))
        {
            color.color = Color.blue;
        }
        
        

    }
}
