using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float countdownSeconds;
     private Text timeText;

    [SerializeField] GameObject gameover2;

    [SerializeField] GameObject title;

    [SerializeField] GameManager gamemanager;
    [SerializeField] center _center;

    Score scr2;

    [SerializeField] GameObject TimeupText;

    public bool timeup;

    private void Start()
    {
        timeText = GetComponent<Text>();
        countdownSeconds = 30;

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
            // 0•b‚É‚È‚Á‚½‚Æ‚«‚Ìˆ—

            scr2.ScoreManager();

            title.SetActive(true);

            this.gameObject.SetActive(false);

            TimeupText.SetActive(true);

            timeup = true;

        }
    }
}