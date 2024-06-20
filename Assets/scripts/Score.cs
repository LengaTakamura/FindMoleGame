using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int _score = 0;　//スコアの初期値を０に設定

    private Text scoreText;   
    void Start()
    {
       scoreText = GetComponent<Text>(); //このスクリプトが紐づいているオブジェクトかTextコンポーネントを持ってきて格納

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
        }

        if (_score >=1)  //スコアが1以上の時に表示するテキスト
        {
            scoreText.text = "スコアは" + _score + "点です！特になし！";
        }

        if (_score >= 3)　//スコアが３以上の時に表示するテキスト
        {
            scoreText.text = "すごい！スコアは" + _score + "点です";
        }

        if (_score >= 5)　//スコアが５以上の時に表示するテキスト
        {
            scoreText.text = "天才！スコアは" + _score + "点です";
        }

    }
}
