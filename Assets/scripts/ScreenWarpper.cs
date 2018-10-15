using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWarpper : MonoBehaviour
{
    float leftConstraint = Screen.width;
    float rightConsrtraint = Screen.width;
    float bottomConstaraint = Screen.width;
    float topConstraint = Screen.height;
    float buffer = 1.0f;
    Camera cam;
    float distanceZ;

    // det här bestämer vad upp och ner är samt höger och vänster
    void Start()
    {
        cam = Camera.main;
        distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);
        leftConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
        rightConsrtraint = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
        bottomConstaraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).y;
        topConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, distanceZ)).y;
    }

    public void FixedUpdate()
    {
        // den här koden säger att: om skeppet åker åt vänster kant teleportera skeppet till höger kant
        if(transform.position.x < leftConstraint - buffer)
        {
            transform.position = new Vector3(rightConsrtraint + buffer, transform.position.y, transform.position.z);
        }
        // denna gör nästan samma sak bara att det är det är motsatsen
        if(transform.position.x > rightConsrtraint + buffer)
        {
            transform.position = new Vector3(leftConstraint - buffer, transform.position.y, transform.position.z);
        }
        // detta gör att om skeppet åker till botten så teleporterar skeppet till toppen
        if (transform.position.y < bottomConstaraint - buffer)
        {
            transform.position = new Vector3(transform.position.x, topConstraint + buffer, transform.position.z);
        }
        // denna gör nästan samma sak som den över bara att det är motsatsen
        if (transform.position.y > topConstraint + buffer)
        {
            transform.position = new Vector3(transform.position.x, bottomConstaraint - buffer, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
