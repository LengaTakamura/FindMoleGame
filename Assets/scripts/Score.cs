using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int _score = 0;�@//�X�R�A�̏����l���O�ɐݒ�

    private Text scoreText;   

    private AudioSource _audioSource;

    //[SerializeField] AudioClip[] _clipsList;

    [SerializeField]List<AudioClip> _clipsList= new List<AudioClip>();


    void Start()
    {
       scoreText = GetComponent<Text>(); //���̃X�N���v�g���R�Â��Ă���I�u�W�F�N�g��Text�R���|�[�l���g�������Ă��Ċi�[

       _audioSource = GetComponent<AudioSource>();  
    }
    public void AddScoreCount()�@//�X�R�A���J�E���g���郁�\�b�h
    {
        _score += 1;�@//�J�E���g���P�����₷
    }

   public void ScoreManager()�@//�X�R�A��\�����郁�\�b�h
    {

        if (_score == 0)�@//�X�R�A���O�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�c�O�I�X�R�A��" + _score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[0]);
        }

        if (_score >=1)  //�X�R�A��1�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�X�R�A��" + _score + "�_�ł��I���ɂȂ��I";

            _audioSource.PlayOneShot(_clipsList[1]);
        }

        if (_score >= 5)�@//�X�R�A��5�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�������I�X�R�A��" + _score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[2]);
        }

        if (_score >= 8)�@//�X�R�A��8�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�V�ˁI�X�R�A��" + _score + "�_�ł�";

            _audioSource.PlayOneShot(_clipsList[2]);
        }
        if (_score >= 10)�@//�X�R�A��10�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "���O�͒@�������O���̐����o���Ă���̂��H�i" + _score + "�j";

            _audioSource.PlayOneShot(_clipsList[3]);
        }
    }
}
