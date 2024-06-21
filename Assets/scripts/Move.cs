using UnityEngine;

public class Move : MonoBehaviour
{
    public int _num = 1;　//右に動くか左に動くかを決める変数num

    Vector2 _pos;  //オブジェクトの位置を格納するVector変数

    private void Start()
    {
        _pos = transform.position;
    }


    void Update()
    {
        

        transform.Translate(transform.right * Time.deltaTime * 200 * _num);　//位置を動かす処理 time.timeとの違い

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("aaa");

        if (collision.gameObject.tag == "right")
        {
            _num = -1;
        }

        if (collision.gameObject.tag == "left")
        {
            _num = 1;   
        }
        
    }
}
