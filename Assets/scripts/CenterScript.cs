using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CenterScript : MonoBehaviour
{

    [SerializeField] GameObject _ObjKuromaru; //�s���������ʒu�Ɉړ�����J�[�\��kuromaru���i�[����ϐ�m_kuromaru���V���A����


    [SerializeField] GameObject _distance;

    TextMeshProUGUI _textSystem;�@// ���̃I�u�W�F�N�g�ɂ���e�L�X�g�R���|�[�l���g���i�[����ϐ�

    Spawn _spawn1;

    [SerializeField] GameObject _effect;

    int _times;

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

    [SerializeField] GameObject _audioSystem;

    AudioSource _audioSource;

    public bool GameOver;

    bool one = true;
    void Start()
    {
        _ObjKuromaru = GameObject.Find("kuromaru");

        _spawn1 = GameObject.Find("Spawn Area").GetComponent<Spawn>();

        _textSystem = _distance.GetComponent<TextMeshProUGUI>();

        slider = GameObject.Find("Slider").GetComponent<Slider>();

        timer1 = GameObject.FindObjectOfType<Timer>();

        scr = GameObject.FindAnyObjectByType<Score>();

        scr = FindFirstObjectByType<Score>();

        _audioSource = _audioSystem.GetComponent<AudioSource>();

        //HP���ő�HP�Ɠ����l�ɁB
        Hp = maxHp;

        _times = 0;

        _spawn1.SpawnCenter();
    }

    void Update()

    {
        if (timer1.timeup == true || GameOver == true)
        {
            this.enabled = false;
        }

        if (slider.value == 0 && one)
        {
            one = false;

            _audioSource.Pause();

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

            _times++;

            Vector2 posi = transform.position;
            Vector2 posi2 = _ObjKuromaru.transform.position;

            distance = (int)(posi2 - posi).magnitude;

            //Debug.Log("������" + distance);

            _textSystem.text = "������" + distance;

            if (distance <= 1)
            {
                slider.value = maxHp;
                Hp = maxHp;
                //HP���ő�HP�Ɠ����l��

                _times = 0;

                _textSystem.text = "���̃��O����T�����I";

                Instantiate(effect);

                _spawn1.Effect();

                _spawn1.SpawnCenter();

            }
            else
            {
                if (_times > 1)
                {
                    Hp--;
                    slider.value = Hp;
                }

            }
        }

    }

}
