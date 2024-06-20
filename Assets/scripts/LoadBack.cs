using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadBack : MonoBehaviour
{
    public void OnBackButtun()
    {
        SceneManager.LoadScene("title");
    }
}
