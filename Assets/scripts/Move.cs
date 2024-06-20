using UnityEngine;

public class Move : MonoBehaviour
{
    public int num = 1;　//右に動くか左に動くかを決める変数num

    Vector2 pos;　　//オブジェクトの位置を格納するVector変数
    void Update()
    {
        pos = transform.position;　//オブジェクトの位置を格納

        transform.Translate(transform.right * Time.deltaTime * 100 * num);　//位置を動かす処理

        if (pos.x > 900)　//
        {
            num = -1;

        }
        if (pos.x < 70)
        {
            num = 1;

        }
    }
}
