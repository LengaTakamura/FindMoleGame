using UnityEngine;

public class Move : MonoBehaviour
{
    public int num = 1;�@//�E�ɓ��������ɓ����������߂�ϐ�num

    Vector2 pos;  //�I�u�W�F�N�g�̈ʒu���i�[����Vector�ϐ�

    private void Start()
    {
        pos = transform.position;
    }


    void Update()
    {
        

        transform.Translate(transform.right * Time.deltaTime * 200 * num);�@//�ʒu�𓮂������� time.time�Ƃ̈Ⴂ

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("aaa");

        if (collision.gameObject.tag == "right")
        {
            num = -1;
        }

        if (collision.gameObject.tag == "left")
        {
            num = 1;   
        }
        
    }
}
