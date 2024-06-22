using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Score : MonoBehaviour
{
    public int  score = 0;�@//�X�R�A�̏����l���O�ɐݒ�

    private Text scoreText;   

    private AudioSource _audioSource;

    //[SerializeField] AudioClip[] _clipsList;

    [SerializeField]List<AudioClip> _clipsList= new List<AudioClip>();


    void Start()
    {
        DontDestroyOnLoad(this);

       scoreText = GetComponent<Text>(); //���̃X�N���v�g���R�Â��Ă���I�u�W�F�N�g��Text�R���|�[�l���g�������Ă��Ċi�[

       _audioSource = GetComponent<AudioSource>();  


    }
    public void AddScoreCount()�@//�X�R�A���J�E���g���郁�\�b�h
    {
        score += 1;�@//�J�E���g���P�����₷
    }

   public void ScoreManager()�@//�X�R�A��\�����郁�\�b�h
    {
        PlayerPrefs.SetInt("score", score);

        if (score == 0)�@//�X�R�A���O�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�c�O�I�X�R�A��" + score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[0]);
        }
        else if (score >= 10)�@//�X�R�A��10�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "���O�͒@�������O���̐����o���Ă���̂��H�i" + score + "�j";

            _audioSource.PlayOneShot(_clipsList[3]);
        }
        else if (score >= 8)�@//�X�R�A��8�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�V�ˁI�X�R�A��" + score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[2]);
        }

        else if (score >= 5)�@//�X�R�A��5�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�������I�X�R�A��" + score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        else if (score >=1)  //�X�R�A��1�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�X�R�A��" + score + "�_�ł��I���ɂȂ��I";

            _audioSource.PlayOneShot(_clipsList[1]);
        }

    }
}
