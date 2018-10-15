using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchanger : MonoBehaviour
{
    public SpriteRenderer rend;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //denna gör att när man trycker på space så byter skeppet färg
        if (Input.GetKey(KeyCode.Space))
        {
            // denna bestämer att det ska vara en random färg
            Color newColor = new Color
                (
                Random.value,
                Random.value,
                Random.value
                );
            // detta lägger färgen på skeppet
            rend.color = newColor;
        }
    }
}
