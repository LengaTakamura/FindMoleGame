using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    public void OnStartButtun ()　// スタートボタンを押したときの処理
    {
        SceneManager.LoadScene("game"); //gameシーンに移行する
    }
}