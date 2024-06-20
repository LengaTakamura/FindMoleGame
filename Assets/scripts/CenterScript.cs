using UnityEngine;
using UnityEngine.UI;

public class CenterScript : MonoBehaviour
{

    [SerializeField] GameObject m_kuromaru; //�s���������ʒu�Ɉړ�����J�[�\��kuromaru���i�[����ϐ�m_kuromaru���V���A����

    Text textsystem;�@// ���̃I�u�W�F�N�g�ɂ���e�L�X�g�R���|�[�l���g���i�[����ϐ�

    Spawn spawn1;

    [SerializeField] GameObject _effect;

    int times;

    public int distance;

    Slider slider;

    int maxHp = 5;
    int Hp;

    [SerializeField] GameObject gameover;

    [SerializeField] GameObject title;

    Score scr;

    [SerializeField] GameObject timer;

    Timer timer1;

    [SerializeField] Stop stp;

    [SerializeField] GameObject effect;

    [SerializeField] Kuromaru _kuromaru;

    public bool GameOver;
    void Start()
    {
        m_kuromaru = GameObject.Find("kuromaru");

        spawn1 = GameObject.Find("Spawn Area").GetComponent<Spawn>();

        textsystem = GameObject.Find("Distance").GetComponent<Text>();

        slider = GameObject.Find("Slider").GetComponent<Slider>();

        timer1 = GameObject.FindObjectOfType<Timer>();

        scr = GameObject.FindAnyObjectByType<Score>();

        scr = FindFirstObjectByType<Score>();

        //HP���ő�HP�Ɠ����l�ɁB
        Hp = maxHp;

        times = 0;

        spawn1.SpawnCenter();
    }

    void Update()

    {
        if (timer1.timeup == true || GameOver == true)
        {
            this.enabled = false;
        }

        if (slider.value == 0)

        {
            Instantiate(effect, transform.position, Quaternion.identity);

            timer.SetActive(false);

            scr.ScoreManager();

            gameover.SetActive(true);

            title.SetActive(true);

            GameOver = true;

           
        }
        if (Input.GetButtonDown("Fire1"))
        {
            _kuromaru.Movement();

            times++;

            Vector2 posi = transform.position;
            Vector2 posi2 = m_kuromaru.transform.position;

            distance = (int)(posi2 - posi).magnitude;

            //Debug.Log("������" + distance);

            textsystem.text = "������" + distance;

            if (distance <= 1)
            {


                slider.value = maxHp;
                Hp = maxHp;
                //HP���ő�HP�Ɠ����l��

                times = 0;


                Debug.Log("�����I�s�������Z�b�g");

                textsystem.text = "���̃��O����T�����I";

                Instantiate(effect);             

                spawn1.Effect();

                spawn1.SpawnCenter();

            }
            else
            {
                if (times > 1)
                {
                    Hp--;
                    slider.value = Hp;
                    Debug.Log(times);
                }

            }
        }

    }


}
