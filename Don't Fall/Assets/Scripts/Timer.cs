﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finish = false;

    void Start()
    {
        startTime = Time.time;
  
    }

    void Update()
    {
        if (finish)
            return;
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = "Time: " + minutes + ":" + seconds;
    }

    public void Finish()
    {
        timerText.color = Color.yellow;
        finish = true;
    }
}
