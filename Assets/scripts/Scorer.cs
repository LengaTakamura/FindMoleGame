using System;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    private static int[] scores = new int[7];

    [SerializeField] Text[] texts;

    Score _score;

    void Start()
    {
        _score = GetComponent<Score>();

        scores[6] = _score.score;

        Array.Sort(scores);

        Array.Reverse(scores);

        GetRanking();


    }

    void GetRanking()
    {
        for (int i = 0; i < scores.Length - 1; i++)
        {
            texts[i].text = "ƒXƒRƒA" + scores[i];

        }

    }
}
