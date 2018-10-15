using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSpawn : MonoBehaviour
{
    // dom här public variablerna bestämer att det är skeppet som ska ha en random spawn plats
    public GameObject theplayer;
    // dom här public bästemer ställerna där skeppet kan spawna
    public float placeX;
    public float placeY;
    // Use this for initialization
    void Start()
    {
        // det här bästemer vilken area skeppet kan spawna i
        placeX = Random.Range(-8.89f, 8.86f);
        placeY = Random.Range(-5.00f, 5.00f);
        // detta spawnar skeppet i PlaceX och PlaceY arean
        theplayer.transform.position = new Vector3(placeX, placeY, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}