using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int _score = 0;　//スコアの初期値を０に設定

    private Text scoreText;   

    private AudioSource _audioSource;

    //[SerializeField] AudioClip[] _clipsList;

    [SerializeField]List<AudioClip> _clipsList= new List<AudioClip>();


    void Start()
    {
       scoreText = GetComponent<Text>(); //このスクリプトが紐づいているオブジェクトかTextコンポーネントを持ってきて格納

       _audioSource = GetComponent<AudioSource>();  
    }
    public void AddScoreCount()　//スコアをカウントするメソッド
    {
        _score += 1;　//カウントを１ずつ増やす
    }

   public void ScoreManager()　//スコアを表示するメソッド
    {

        if (_score == 0)　//スコアが０の時に表示するテキスト
        {
            scoreText.text = "残念！スコアは" + _score + "点です";

            _audioSource.PlayOneShot(_clipsList[0]);
        }

        if (_score >=1)  //スコアが1以上の時に表示するテキスト
        {
            scoreText.text = "スコアは" + _score + "点です！特になし！";

            _audioSource.PlayOneShot(_clipsList[1]);
        }

        if (_score >= 5)　//スコアが5以上の時に表示するテキスト
        {
            scoreText.text = "すごい！スコアは" + _score + "点です";

            _audioSource.PlayOneShot(_clipsList[2]);
        }

        if (_score >= 8)　//スコアが8以上の時に表示するテキスト
        {
            scoreText.text = "天才！スコアは" + _score + "点です";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        if (_score >= 10)　//スコアが10以上の時に表示するテキスト
        {
            scoreText.text = "お前は叩いたモグラの数を覚えているのか？（" + _score + "）";

            _audioSource.PlayOneShot(_clipsList[3]);
        }
    }
}
