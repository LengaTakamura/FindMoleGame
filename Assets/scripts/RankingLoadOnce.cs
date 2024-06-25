using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingLoadOnce : MonoBehaviour
{
    GameObject _score;

    private void Start()
    {
        try
        {
            _score = GameObject.Find("ScoreManeger");
        }
        catch { }

    }
    public void OnceScore()
    {
       

        SceneManager.LoadScene("Ranking");

    }
    
}
