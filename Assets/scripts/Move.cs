using UnityEngine;

public class Move : MonoBehaviour
{
    public int _num = 1;�@//�E�ɓ��������ɓ����������߂�ϐ�num

    Vector2 _pos;  //�I�u�W�F�N�g�̈ʒu���i�[����Vector�ϐ�

    private void Start()
    {
        _pos = transform.position;
    }


    void Update()
    {
        

        transform.Translate(transform.right * Time.deltaTime * 200 * _num);�@//�ʒu�𓮂������� time.time�Ƃ̈Ⴂ

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
