using UnityEngine;

public class Move : MonoBehaviour
{
    public int num = 1;�@//�E�ɓ��������ɓ����������߂�ϐ�num

    Vector2 pos;�@�@//�I�u�W�F�N�g�̈ʒu���i�[����Vector�ϐ�
    void Update()
    {
        pos = transform.position;�@//�I�u�W�F�N�g�̈ʒu���i�[

        transform.Translate(transform.right * Time.deltaTime * 100 * num);�@//�ʒu�𓮂�������

        if (pos.x > 900)�@//
        {
            num = -1;

        }
        if (pos.x < 70)
        {
            num = 1;

        }
    }
}
