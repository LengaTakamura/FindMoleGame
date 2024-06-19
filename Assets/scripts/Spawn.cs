using UnityEngine;
public class Spawn : MonoBehaviour
{
    
    public GameObject m_center;�@//�����Ȃ��ڕWcenter���i�[����ϐ�

    [SerializeField] GameObject effect; //�������ɏo�Ă��郂�O�����i�[����ϐ�

    [SerializeField] GameObject kuro;�@// �s��(kuromaru)���i�[����ϐ�

    Score score;�@//Score�X�N���v�g���i�[����ϐ�

    private void Awake()�@//Start���������������s��
    {
        score = GameObject.FindAnyObjectByType<Score>();�@//�q�G�����L�[�̒�����Score�X�N���v�g������Object��T���Ă���Score��ϐ�score�Ɋi�[
    }

    void Start()
    {
        m_center = GameObject.Find("center");�@//m_center��center�Ƃ������O�̃Q�[���I�u�W�F�N�g���i�[
    }

    public void SpawnCenter()�@//�ڕW����ʓ��̃����_���Ȉʒu�Ɉړ�������
    {
        float x = Random.Range(-9.25f, 9.25f); //��ʏ�͈̔�(X)���Ń����_���ȍ��W���擾����

        float y = Random.Range(-4f, 4f); // ��ʏ�͈̔�(Y)���Ń����_���ȍ��W���擾����


        m_center.transform.position = new Vector2 (x, y);    // GameObject����L�Ō��܂��������_���ȏꏊ�Ɉړ�
                                                             


        //var centerComponent = center2.GetComponent<center>();
        //centerComponent.enabled = true;
        //m_healthSystem.Center = centerComponent;
        //�R���|�[�l���g�Ƀ`�F�b�N������

    }

    public void Effect()    //���O�����o�Ă���
    {
        Instantiate(effect,kuro.transform.position,kuro.transform.rotation); //�J�E���g�𑝂₷

        score.AddScoreCount();  //�X�R�A���J�E���g���郁�\�b�h���Ăяo��(���O�����o�邽�тɃJ�E���g���P���₷)
       
    }
}
