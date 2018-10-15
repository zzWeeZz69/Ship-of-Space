using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
    public Text timertext;
    public float StartTime;
    bool timeStart;
    bool start = false;
    // startar timern
    void Start()
    { 
        timeStart = false;
    }
   
    // Update is called once per frame
    void Update()
    {
        // gör att när man trycker på space så startar timern
        if (Input.GetKey(KeyCode.Space))
        {
            timeStart = true;
            if (start == false)
            {
                start = true;
                StartTime = Time.time;
            }
        }
        if (timeStart == true)
        {
            // detta bestämer hur timer startar
            float t = Time.time - StartTime;
            // bestämer hur lång en minut är, och ur lång en sekund är
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f0");
            // det här bestämer vad som ska vissas
            timertext.text = "Timer " + minutes + ":" + seconds;
        }
    }
}
