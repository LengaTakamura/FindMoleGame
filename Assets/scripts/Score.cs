using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Score : MonoBehaviour
{
    public int  score = 0;　//スコアの初期値を０に設定

    private Text scoreText;   

    private AudioSource _audioSource;

    //[SerializeField] AudioClip[] _clipsList;

    [SerializeField]List<AudioClip> _clipsList= new List<AudioClip>();


    void Start()
    {
        DontDestroyOnLoad(this);

       scoreText = GetComponent<Text>(); //このスクリプトが紐づいているオブジェクトかTextコンポーネントを持ってきて格納

       _audioSource = GetComponent<AudioSource>();  


    }
    public void AddScoreCount()　//スコアをカウントするメソッド
    {
        score += 1;　//カウントを１ずつ増やす
    }

   public void ScoreManager()　//スコアを表示するメソッド
    {
        PlayerPrefs.SetInt("score", score);

        if (score == 0)　//スコアが０の時に表示するテキスト
        {
            scoreText.text = "残念！スコアは" + score + "点です";

            _audioSource.PlayOneShot(_clipsList[0]);
        }
        else if (score >= 10)　//スコアが10以上の時に表示するテキスト
        {
            scoreText.text = "お前は叩いたモグラの数を覚えているのか？（" + score + "）";

            _audioSource.PlayOneShot(_clipsList[3]);
        }
        else if (score >= 8)　//スコアが8以上の時に表示するテキスト
        {
            scoreText.text = "天才！スコアは" + score + "点です";

            _audioSource.PlayOneShot(_clipsList[2]);
        }

        else if (score >= 5)　//スコアが5以上の時に表示するテキスト
        {
            scoreText.text = "すごい！スコアは" + score + "点です";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        else if (score >=1)  //スコアが1以上の時に表示するテキスト
        {
            scoreText.text = "スコアは" + score + "点です！特になし！";

            _audioSource.PlayOneShot(_clipsList[1]);
        }

    }
}
