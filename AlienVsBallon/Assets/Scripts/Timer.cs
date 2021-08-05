using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text tiempoText;
    public float tiempo = 0.0f;
    private float elapsedTime;
    private TimeSpan timePlaying;
    public void Update()
    {
        elapsedTime += Time.deltaTime;
        timePlaying = TimeSpan.FromSeconds(elapsedTime);
        string timePlayingStr = timePlaying.ToString("mm':'ss");
        tiempoText.text = timePlayingStr;

        //tiempo += Time.deltaTime;
        //tiempoText.text = "" + tiempo;
    }

}
