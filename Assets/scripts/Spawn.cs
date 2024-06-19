using UnityEngine;
public class Spawn : MonoBehaviour
{
    
    public GameObject m_center;　//見えない目標centerを格納する変数

    [SerializeField] GameObject effect; //成功時に出てくるモグラを格納する変数

    [SerializeField] GameObject kuro;　// ピン(kuromaru)を格納する変数

    Score score;　//Scoreスクリプトを格納する変数

    private void Awake()　//Startよりも早く処理を行う
    {
        score = GameObject.FindAnyObjectByType<Score>();　//ヒエラルキーの中からScoreスクリプトがあるObjectを探してそのScoreを変数scoreに格納
    }

    void Start()
    {
        m_center = GameObject.Find("center");　//m_centerにcenterという名前のゲームオブジェクトを格納
    }

    public void SpawnCenter()　//目標を画面内のランダムな位置に移動させる
    {
        float x = Random.Range(-9.25f, 9.25f); //画面上の範囲(X)内でランダムな座標を取得する

        float y = Random.Range(-4f, 4f); // 画面上の範囲(Y)内でランダムな座標を取得する


        m_center.transform.position = new Vector2 (x, y);    // GameObjectを上記で決まったランダムな場所に移動
                                                             


        //var centerComponent = center2.GetComponent<center>();
        //centerComponent.enabled = true;
        //m_healthSystem.Center = centerComponent;
        //コンポーネントにチェックを入れる

    }

    public void Effect()    //モグラが出てくる
    {
        Instantiate(effect,kuro.transform.position,kuro.transform.rotation); //カウントを増やす

        score.AddScoreCount();  //スコアをカウントするメソッドを呼び出す(モグラが出るたびにカウントを１増やす)
       
    }
}
