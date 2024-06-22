using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Score : MonoBehaviour
{
    public  int  score = 0;�@//�X�R�A�̏����l���O�ɐݒ�

    Text _scrText;

    private AudioSource _audioSource;

    //[SerializeField] AudioClip[] _clipsList;

    [SerializeField]List<AudioClip> _clipsList= new List<AudioClip>();

    
    void Start()
    {
        _scrText =GameObject.Find("Scoretext").GetComponent<Text>();

        DontDestroyOnLoad(this);
       
       _audioSource = GetComponent<AudioSource>();  

        


    }
    public void AddScoreCount()�@//�X�R�A���J�E���g���郁�\�b�h
    {
        score += 1;�@//�J�E���g���P�����₷
    }

   public void ScoreManager()�@//�X�R�A��\�����郁�\�b�h
    {
     
        if (score == 0)�@//�X�R�A���O�̎��ɕ\������e�L�X�g
        {
            _scrText.text = "�c�O�I�X�R�A��" + score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[0]);
        }
        else if (score >= 10)�@//�X�R�A��10�ȏ�̎��ɕ\������e�L�X�g
        {
            _scrText.text = "���O�͒@�������O���̐����o���Ă���̂��H�i" + score + "�j";

            _audioSource.PlayOneShot(_clipsList[3]);
        }
        else if (score >= 8)�@//�X�R�A��8�ȏ�̎��ɕ\������e�L�X�g
        {
            _scrText.text = "�V�ˁI�X�R�A��" + score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[2]);
        }

        else if (score >= 5)�@//�X�R�A��5�ȏ�̎��ɕ\������e�L�X�g
        {
            _scrText.text = "�������I�X�R�A��" + score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        else if (score >=1)  //�X�R�A��1�ȏ�̎��ɕ\������e�L�X�g
        {
            _scrText.text = "�X�R�A��" + score + "�_�ł��I���ɂȂ��I";

            _audioSource.PlayOneShot(_clipsList[1]);
        }

    }
}
