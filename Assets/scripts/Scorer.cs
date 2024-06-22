using System;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    private static int[] scores = new int[7];

    [SerializeField] Text[] texts;

    bool count;

    // Start is called before the first frame update
    void Start()
    {
        if(count == false)
        {
            PlayerPrefs.DeleteAll();

            count = true;
        }


        scores[6] = PlayerPrefs.GetInt("score", 0);

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
