using UnityEngine;
public class Spawn : MonoBehaviour
{
    public GameObject m_center;�@//�����Ȃ��ڕWcenter���i�[����ϐ�

    [SerializeField] GameObject effect; //�������ɏo�Ă��郂�O�����i�[����ϐ�

    [SerializeField] GameObject kuro;�@// �s��(kuromaru)���i�[����ϐ�

   
    void Start()
    {
        m_center = GameObject.Find("Center");�@//m_center��center�Ƃ������O�̃Q�[���I�u�W�F�N�g���i�[
    }
    public void SpawnCenter()�@//�ڕW����ʓ��̃����_���Ȉʒu�Ɉړ�������
    {
        float x = Random.Range(-8.5f, 8.5f); //��ʏ�͈̔�(X)���Ń����_���ȍ��W���擾����

        float y = Random.Range(-4.5f, 4.5f); // ��ʏ�͈̔�(Y)���Ń����_���ȍ��W���擾����

        m_center.transform.position = new Vector2(x, y);    // GameObject����L�Ō��܂��������_���ȏꏊ�Ɉړ�

    }
    public void Effect()    //���O�����o�Ă���
    {
        Instantiate(effect, kuro.transform.position, kuro.transform.rotation); //�J�E���g�𑝂₷

    }
}
