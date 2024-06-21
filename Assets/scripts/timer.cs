using System;
using TMPro;
using UnityEngine;
public class Timer : MonoBehaviour
{
     float countdownSeconds;

     private TextMeshProUGUI timeText;

    Score scr2;

    [SerializeField] GameObject title;
   
    [SerializeField] CenterScript _center;


    [SerializeField] GameObject TimeupText;

    [SerializeField] Stop st;

    [SerializeField] GameObject centerr;   

    public bool timeup;

    [SerializeField] GameObject _effect1;

    bool once= true;

    [SerializeField] GameObject _audioSystem;

    AudioSource _audioSource;


    private void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();

        countdownSeconds = 31;

        scr2 = GameObject.FindAnyObjectByType<Score>();

        _audioSource = _audioSystem.GetComponent<AudioSource>();
    }

    void Update()
    {
        Invoke(nameof(AddTimer), 3.5f);
    }

    public void AddTimer()
    {
        _audioSource.Play();

        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0 && once )
        {
            once = false;
        
            Instantiate(_effect1, centerr.transform.position, Quaternion.identity);

            if (_center.GameOver) return;

            scr2.ScoreManager();

            title.SetActive(true);

            this.gameObject.SetActive(false);

            TimeupText.SetActive(true);

            timeup = true;

          
        }
    }
}