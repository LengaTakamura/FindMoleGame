using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int _score = 0;�@//�X�R�A�̏����l���O�ɐݒ�

    private Text scoreText;   
    void Start()
    {
       scoreText = GetComponent<Text>(); //���̃X�N���v�g���R�Â��Ă���I�u�W�F�N�g��Text�R���|�[�l���g�������Ă��Ċi�[

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
        }

        if (_score >=1)  //�X�R�A��1�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�X�R�A��" + _score + "�_�ł��I���ɂȂ��I";
        }

        if (_score >= 3)�@//�X�R�A���R�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�������I�X�R�A��" + _score + "�_�ł�";
        }

        if (_score >= 5)�@//�X�R�A���T�ȏ�̎��ɕ\������e�L�X�g
        {
            scoreText.text = "�V�ˁI�X�R�A��" + _score + "�_�ł�";
        }

    }
}
