using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    private static int[] scores = new int[7];

    [SerializeField] Text[] texts;

    Score _scoreManager;

    
    void Start()
    {
        try
        {
            _scoreManager = GameObject.Find("ScoreManeger").GetComponent<Score>();
        }
        catch 
        {
            return;
            
        }

        if (_scoreManager == null)
        {
            scores[0] = 0;
            scores[1] = 0;
            scores[2] = 0;
            scores[3] = 0;
            scores[4] = 0;
            scores[5] = 0;
        }
        else if (_scoreManager != null )
        {


            scores[6] = _scoreManager.score;

            Array.Sort(scores);

            Array.Reverse(scores);

            GetRanking();
        }
    }
    void GetRanking()
    {
        for (int i = 0; i < scores.Length - 1; i++)
        {
            texts[i].text = " " + scores[i];

        }

    }
}
