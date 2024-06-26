using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;　//スコアの初期値を０に設定

    Text _scrText;

    private AudioSource _audioSource;

    [SerializeField] List<AudioClip> _clipsList = new List<AudioClip>();


    private static bool origin = false;

    private void Awake()
    {
        if (origin == false)
        {
            DontDestroyOnLoad(this);

            origin = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {

        _audioSource = GetComponent<AudioSource>();

        try
        {
            _scrText = GameObject.Find("ScoreText").GetComponent<Text>();
        }
        catch { }
    }
    public void AddScoreCount()　//スコアをカウントするメソッド
    {
        score += 1;　//カウントを１ずつ増やす

        //Debug.Log(score);
    }

    public void ScoreManager()　//スコアを表示するメソッド
    {
        Debug.Log(score + "最後に来てほしい");

        _scrText = GameObject.Find("ScoreText").GetComponent<Text>();

        if (score == 0)　//スコアが０の時に表示するテキスト
        {
            _scrText.text = "残念！スコアは" + score + "点です";

            _audioSource.PlayOneShot(_clipsList[0]);
        }
        else if (score >= 10)　//スコアが10以上の時に表示するテキスト
        {
            _scrText.text = "お前は叩いたモグラの数を覚えているのか？（" + score + "）";

            _audioSource.PlayOneShot(_clipsList[3]);
        }
        else if (score >= 8)　//スコアが8以上の時に表示するテキスト
        {
            _scrText.text = "天才！スコアは" + score + "点です";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        else if (score >= 5)　//スコアが5以上の時に表示するテキスト
        {
            _scrText.text = "すごい！スコアは" + score + "点です";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        else if (score >= 1)  //スコアが1以上の時に表示するテキスト
        {
            _scrText.text = "スコアは" + score + "点です！特になし！";

            _audioSource.PlayOneShot(_clipsList[1]);
        }
    }
}

