using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadBack : MonoBehaviour
{
    public void OnBackButtun() //ボタンを押したときの処理
    {
        SceneManager.LoadScene("title");　//titleシーンに移行する
    }
}
