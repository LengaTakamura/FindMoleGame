using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    GameObject _score;

    bool once;

    private void Start()
    {
      
    }

    public void OnStartButtun()�@// �X�^�[�g�{�^�����������Ƃ��̏���
    {
        try
        {
            _score.SetActive(true);
        }
        catch { }   
        try
        {
            
            var scoreManager = GameObject.Find("ScoreManeger").GetComponent<Score>();

            scoreManager.score = 0;

            Debug.Log("�X�R�A�����Z�b�g");
        }
        catch { }


        SceneManager.LoadScene("game"); //game�V�[���Ɉڍs����
    }

    public void OnLoadRankingButtun()
    {      
        SceneManager.LoadScene("Ranking");
    }
}