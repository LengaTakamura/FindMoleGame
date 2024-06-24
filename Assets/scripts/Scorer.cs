using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    private static int[] scores = new int[7];

    [SerializeField] Text[] texts;

    Score _scoreManager;

    [SerializeField]int count = 1;

    void Start()
    {
        try
        {
            _scoreManager = GameObject.Find("ScoreManeger").GetComponent<Score>();
        }
        catch 
        {
 
        }

        if (Score.score == 0 )
        {
           
            scores[6] = Score.score;

            Array.Sort(scores);

            Array.Reverse(scores);

            GetRanking();

          

            Debug.Log("�X�R�A�Ȃ�" + Score.score);
        }
        else 
        {

            scores[6] = Score.score;

            Array.Sort(scores);

            Array.Reverse(scores);

            GetRanking();

            

            Debug.Log("�X�R�A���v�Z"+ Score.score);
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
