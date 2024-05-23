using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class RunningTimer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerTxt;
 
    float elapsedTime;

  
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Paused()
    {
        Time.timeScale = 0f;
        Debug.Log("Test");
    }

}
