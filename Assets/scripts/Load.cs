using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    GameObject _score;

    bool once;

    private void Start()
    {
      
    }

    public void OnStartButtun()　// スタートボタンを押したときの処理
    {
        try
        {
            _score.SetActive(true);
        }
        catch { }   
        try
        {
            
            var scoreManager = GameObject.Find("ScoreManeger").GetComponent<Score>();

            scoreManager.score = 0;

            Debug.Log("スコアをリセット");
        }
        catch { }


        SceneManager.LoadScene("game"); //gameシーンに移行する
    }

    public void OnLoadRankingButtun()
    {      
        SceneManager.LoadScene("Ranking");
    }
}