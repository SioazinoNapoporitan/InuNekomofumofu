using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManeger : MonoBehaviour
{
    public float now   = 10f;
    public GameObject ClearWindow;

    public Text TimerText;
    string TimeCount;
    int second;

    void Start()
    {
        TimerText = TimerText.GetComponent<Text>();
    }

    void FixedUpdate()
    {
        if(now >= 0f)
        {
            now    -= Time.deltaTime;
            second  = (int)now;

        if (now < 0f)// もし now が 0 未満に下がっていたら
        {
            now = 0f;
            ClearWindow.SetActive(true);
        }
            TimeCount = second.ToString("F0");
            TimerText.text = TimeCount;
        }
    
    }
}
