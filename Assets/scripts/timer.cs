using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float countdownSeconds;
     private TextMeshProUGUI timeText;

    [SerializeField] GameObject title;
   
    [SerializeField] CenterScript _center;

    Score scr2;

    [SerializeField] GameObject TimeupText;

    [SerializeField] Stop st;

    public bool timeup;

    private void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        countdownSeconds = 31;

        scr2 = GameObject.FindAnyObjectByType<Score>();
    }

    void Update()
    {
        Invoke(nameof(AddTimer), 3f);
    }

    public void AddTimer()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0)
        {
            if (_center.GameOver) return;
            // 0秒になったときの処理


            scr2.ScoreManager();

            title.SetActive(true);

            this.gameObject.SetActive(false);

            TimeupText.SetActive(true);

            timeup = true;

            //st.AddOff();
        }
    }
}