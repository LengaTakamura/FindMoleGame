using UnityEngine;
public class Spawn : MonoBehaviour
{
    public GameObject m_center;　//見えない目標centerを格納する変数

    [SerializeField] GameObject effect; //成功時に出てくるモグラを格納する変数

    [SerializeField] GameObject kuro;　// ピン(kuromaru)を格納する変数

   
    void Start()
    {
        m_center = GameObject.Find("Center");　//m_centerにcenterという名前のゲームオブジェクトを格納
    }
    public void SpawnCenter()　//目標を画面内のランダムな位置に移動させる
    {
        float x = Random.Range(-8.5f, 8.5f); //画面上の範囲(X)内でランダムな座標を取得する

        float y = Random.Range(-4.5f, 4.5f); // 画面上の範囲(Y)内でランダムな座標を取得する

        m_center.transform.position = new Vector2(x, y);    // GameObjectを上記で決まったランダムな場所に移動

    }
    public void Effect()    //モグラが出てくる
    {
        Instantiate(effect, kuro.transform.position, kuro.transform.rotation); //カウントを増やす

    }
}
