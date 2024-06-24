using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    [SerializeField]Score Score;
    public void Start()
    {
        Score.score = 0;

        Debug.Log("Reset"+Score.score);
    }
}
