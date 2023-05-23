using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float countDownStartValue;

    [SerializeField] private TextMeshProUGUI timer;

    private IHMController ihm;
    void Start()
    {
        ihm = GetComponent<IHMController>();
        CountDown();
    }
    public void CountDown()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timer.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("CountDown", 1.0f);
        }
        else
        {
            ihm.CheckGameOver();
        }
    }
    public void EndTime()
    {
        GameController.instance.EndTime = countDownStartValue;
    }

    public void IncreaseTime(float seconds)
    {
        countDownStartValue += 1f;
        Invoke("CountDown", 1.0f);
    }
}
